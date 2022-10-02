//Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа. 
//        Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

//------- 1-й вариант (массив задан + без метода, по блок-схеме) -------

/*string[] stringArray = { "Hello", "Hi", "Tuersday", "1234", "Play", "Iam", "Super", "VIP" };

int size = stringArray.Length;

string[] newArray = new string[size]; 

int i = 0;

while(i < size)
{
    if(stringArray[i].Length <= 3)
    {   
        newArray[i] = stringArray[i];
        Console.Write(newArray[i] + " "); 
    }
    i++;
}*/


//------- 2-й вариант (массив задан + через метод) -------

void ShowArray(string[] array)
{
    int size = array.Length;
    string[] newArray = new string[size];

    for(int i = 0; i < size; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[i] = array[i]; //---Формируем новый массив из строк, длинна которых меньше либо равна 3 символам
            Console.Write(newArray[i] + " ");
        }    
        
    }
}

string[] stringArray = { "Hello", "Hi", "Tuersday", "1234", "Play", "Iam", "Super", "VIP" };
ShowArray(stringArray);