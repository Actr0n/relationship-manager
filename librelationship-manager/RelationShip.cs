namespace librelationship_manager
{
    public class RelationShip
    {
        public string Name { get; set; } = string.Empty;
        public RelationObject From { get; set; }
        public RelationObject To { get; set; }
        public override string ToString()
            => $"{From} {Name} {To}";
    }
}