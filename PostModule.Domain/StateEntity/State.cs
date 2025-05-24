namespace PostModule.Domain.StateEntity
{
    public class State
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string CloseStates { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public State(string title)
        {
            Title = title;
            CloseStates = "";
            CreatedAt = DateTime.Now;
        }
        public void Edit(string title)
        {
            Title = title;
        }
        public void ChangeCloseStates(List<int> States)
        {
            CloseStates = String.Join("-", States);
        }
    }
}
