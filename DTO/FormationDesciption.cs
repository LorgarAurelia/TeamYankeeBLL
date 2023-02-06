namespace TeamYankeeBLL.DTO
{
    public class FormationDesciption
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //TODO: FormationtsCost

        public FormationDesciption(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
