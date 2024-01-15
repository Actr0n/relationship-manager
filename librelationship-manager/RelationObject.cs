namespace librelationship_manager
{
    public class RelationObject
    {
        public string Name { get; set; } = string.Empty;
        public List<RelationShip> RelationShips { get; set; } = new List<RelationShip>();
        public string Id { get; set; } = string.Empty;
        public override string ToString() => Name;
    }
}