namespace ToDoList
{
    public partial class Form1 : Form
    {
        List<string> ToDoItems;
        private readonly string _path = Path.Combine("C:\\Users\\hp\\source\\repos\\ToDoList", "Todo.txt");
        public Form1()
        {
            ToDoItems = new List<string>();
            ToDoItems = new ToDoLayout().ReadTask(_path) ?? new List<string>();
            //Logic to populate the list
            InitializeComponent();
            Display.Text = string.Join("\n", ToDoItems);
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            ToDoItems.Add(NewItem_txtbx.Text);
            //add to db
            new ToDoLayout().WriteTask(_path, ToDoItems);
            //refresh the ui
            Display.Text = string.Join("\n", ToDoItems);
        }

        private void View_btn_Click(object sender, EventArgs e)
        {
            ToDoLayout toDo = new ToDoLayout();
            toDo.ReadTask(_path);
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            ToDoLayout toDoLayout = new ToDoLayout();
            //new ToDoLayout().RemoveTask(_path);
        }
    }
}