using Dalssoft.DiagramNet;
using librelationship_manager;

namespace relationship_manager
{
    public partial class Form1 : Form
    {
        public RelationShipManager Manager { get; private set; }
        public BindingSource RelationBindingSource { get; }

        public Form1(RelationShipManager manager)
        {
            InitializeComponent();
            Manager = manager;

            RelationBindingSource = AddDataSource(comboFrom, Manager.Objects, "Name");
            RelationBindingSource = AddDataSource(comboTo, Manager.Objects, "Name");
        }

        private BindingSource AddDataSource<T>(ComboBox control, IEnumerable<T> list, string displayMember)
        {
            BindingSource source = new BindingSource();
            source.DataSource = list;

            control.DataSource = source.DataSource;

            control.DisplayMember = displayMember;
            control.ValueMember = displayMember;
            return source;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (relationshipList.SelectedIndex > -1)
            {
                RelationShip selected = (RelationShip)relationshipList.SelectedItem;
                selected.Name = comboRelation.Text;
            }
            else
            {
                RelationObject from = comboFrom.SelectedItem as RelationObject;
                RelationObject to = comboTo.SelectedItem as RelationObject;

                string comboFromSelectedText = comboFrom.Text;
                string comboToSelectedText = comboTo.Text;

                if (from == null)
                    from = Manager.AddObject(new RelationObject() { Name = comboFromSelectedText, Id = Guid.NewGuid().ToString() });
                if (to == null)
                    to = Manager.AddObject(new RelationObject() { Name = comboToSelectedText, Id = Guid.NewGuid().ToString() });

                Manager.AddRelation(from, to, comboRelation.Text);
            }
            UpdateList();
            ClearInput();
            EnableCombos();
        }

        private void UpdateDesigner()
        {
            ClearDesigner();

            foreach(RelationShip relation in this.relationshipList.Items)
            {
                RectangleElement elemFrom = new RectangleElement(0, 0, 100, 100);
                LabelElement lblFrom = new LabelElement();
                lblFrom.Text = relation.From.Name;
                elemFrom.Label = lblFrom;

                RectangleElement elemTo = new RectangleElement(200, 0, 100, 100);
                LabelElement lblTo = new LabelElement();
                lblTo.Text = relation.To.Name;
                elemTo.Label = lblTo;


                diagramDesigner.Document.AddElement(elemFrom);
                diagramDesigner.Document.AddElement(elemTo);
                diagramDesigner.Document.AddLink(elemFrom, elemTo);
            }
        }

        private void ClearDesigner()
        {
            diagramDesigner.Document.SelectAllElements();
            diagramDesigner.Document.ClearSelection();
        }

        private void EnableCombos()
        {
            comboFrom.Enabled = true;
            comboTo.Enabled = true;
        }

        private void ClearInput()
        {
            comboFrom.Text = string.Empty;
            comboTo.Text = string.Empty;
            comboRelation.Text = string.Empty;
        }

        private void UpdateList()
        {
            relationshipList.Items.Clear();
            foreach(RelationShip rel in Manager.Relations)
            {
                relationshipList.Items.Add(rel);
            }
            UpdateDesigner();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (relationshipList.SelectedItem != null)
            {
                Manager.DeleteRelation((RelationShip)relationshipList.SelectedItem);
                UpdateList();
            }
        }

        private void btnDesel_Click(object sender, EventArgs e)
        {
            relationshipList.SelectedIndex = -1;
            EnableCombos();
        }

        private void relationshipList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (relationshipList.SelectedItem != null)
            {
                LoadInput();
            }
        }

        private void LoadInput()
        {
            RelationShip relationShip = (RelationShip)relationshipList.SelectedItem;

            comboFrom.Text = relationShip.From.Name;
            comboFrom.Enabled = false;
            comboTo.Text = relationShip.To.Name;
            comboTo.Enabled = false;
            comboRelation.Text = relationShip.Name;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            DialogResult res = saveFileDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                Stream stream = saveFileDialog.OpenFile();
                RelationShipManager.ToJson(stream, Manager);
            }

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            DialogResult res = openFileDialog.ShowDialog(this);

            if ( res == DialogResult.OK)
            {
                Manager = RelationShipManager.FromJson(openFileDialog.FileName);
                UpdateList();
            }
        }
    }
}
