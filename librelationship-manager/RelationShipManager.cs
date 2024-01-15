using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librelationship_manager
{
    public class RelationShipManager
    {
        public BindingList<RelationShip> Relations = new BindingList<RelationShip>();
        public BindingList<RelationObject> Objects = new BindingList<RelationObject>();

        public void AddRelation(RelationObject From, RelationObject To, string name)
        {
            RelationShip relation = new RelationShip()
            {
                From = From,
                To = To,
                Name = name
            };
            Relations.Add(relation);
        }
        public void SaveRelation(RelationObject From, RelationObject To, string name, RelationShip relation)
        {
            relation.From = From; relation.To = To; relation.Name = name;
        }
        public void DeleteRelation(RelationShip relation)
        {
            Relations.Remove(relation);
        }

        public RelationObject AddObject(RelationObject relationObject)
        {
            Objects.Add(relationObject);
            return relationObject;
        }
        public static RelationShipManager FromJson(string filePath)
        {
            string content = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<RelationShipManager>(content);
        }
        public static void ToJson(Stream fileStream, RelationShipManager manager)
        {
            string content = JsonConvert.SerializeObject(manager);
            using(StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.WriteLine(content);
                writer.Flush();
            }
        }
    }
}
