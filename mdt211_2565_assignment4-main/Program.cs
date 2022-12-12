class Program
{
    static Stack<Employee> Employee_create(){
        string name = Console.ReadLine();
        int num;
        int.TryParse(Console.ReadLine(),out num);
        Stack<Employee> listem = new Stack<Employee>();
        Employee employee = new Employee(name,num);
        listem.Push(employee);
        return listem;
    }
    static void Main(string[] args)
    {
        Stack<Employee> employee = new Stack<Employee>();
        
    }
}