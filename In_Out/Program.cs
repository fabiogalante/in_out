//Out - Output de number para a variável

int valor;
//DoSomething(125);
DoSomething(out valor);
//Console.WriteLine(valor);

void DoSomething(out int number) //A saida de number para valor, out;
{
    number = 123;
}


//Number está dentro da stack frame da função, por isso não retorna 2
void Increment(ref int number)
{
    number++;
}

int number = 1;
Increment(ref number);
//Console.WriteLine(number);


//In
void IncrementIn(in int number)
{
    //number++; In não pode ser modificado
}


//Params
static void UserParams(params string[] list)
{
    foreach (var t in list)
    {
        Console.WriteLine(t + " ");
    }
}

UserParams();
UserParams("1,2,3", "2", "3");

StudentsParams(new Student("Fabio"), new Student("Isabella"));

//Params
static void StudentsParams(params Student[] itemStudent)
{
    foreach (var t in itemStudent)
    {
        Console.WriteLine(t);
    }
}

public record Student(string Name);