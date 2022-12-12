class Employee{
    private string name;
    private int numeric_number;
    public Employee(string name,int numeric_number){
        this.name = name;
        this.numeric_number = numeric_number;
    }
    public string get_employee(){
        return this.name;
    }
    public int get_employee_number(){
        return this.numeric_number;
    }
}