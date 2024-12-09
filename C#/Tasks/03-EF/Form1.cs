namespace EFApp
{
    public partial class Form1 : Form
    {
        private TodoRepository _repository;
        private BindingSource _bindingSource;
        public Form1()
        {
            InitializeComponent();
            _repository = new TodoRepository();
            _bindingSource = new BindingSource();
            LoadTodos();
        }
        private void LoadTodos()
        {
            _bindingSource.DataSource = _repository.GetAllTodos();
            dataGridView1.DataSource = _bindingSource;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var todo = new Todo { Title = txtTitle.Text, IsCompleted = false };
            _repository.AddTodo(todo);
            LoadTodos();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var todo = (Todo)dataGridView1.SelectedRows[0].DataBoundItem;
                todo.Title = txtTitle.Text;
                todo.IsCompleted = checkBoxCompleted.Checked;
                _repository.UpdateTodo(todo);
                LoadTodos();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var todo = (Todo)dataGridView1.SelectedRows[0].DataBoundItem;
                _repository.DeleteTodo(todo.Id);
                LoadTodos();
            }
        }
    }
}
