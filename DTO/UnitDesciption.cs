namespace TeamYankeeBLL.DTO
{
    public class UnitDesciption
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UnitDesciption(int id, string name)
        {
            Id = id;
            Name = name;
        }
        //TODO: UnitCost
    }
}
