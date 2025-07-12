/*
beecrowd | 1049
Animal

Timelimit: 1
Neste problema, você deverá ler 3 palavras que definem o tipo de animal 
possível segundo o esquema abaixo, da esquerda para a direita.  
Em seguida conclua qual dos animais seguintes foi escolhido, através 
das três palavras fornecidas.

Entrada
A entrada contém 3 palavras, uma em cada linha, necessárias para 
identificar o animal segundo a figura acima, com todas as letras minúsculas.

Saída
Imprima o nome do animal correspondente à entrada fornecida.
*/

using System;
using System.Reflection;

class Animal
{
    public Vertebrado vertebrado;
    public Invertebrado invertebrado;

    public Animal()
    {
        vertebrado = new Vertebrado();
        invertebrado = new Invertebrado();
    }
}

class Invertebrado
{
    public Inseto inseto;
    public Anelideo anelideo;

    public Invertebrado()
    {
        inseto = new Inseto();
        anelideo = new Anelideo();
    }
}

class Inseto
{
    public string hematofago;
    public string herbivoro;

    public Inseto()
    {
        hematofago = "pulga";
        herbivoro = "lagarta";
    }
}

class Anelideo
{
    public string hematofago;
    public string onivoro;

    public Anelideo()
    {
        hematofago = "sanguessuga";
        onivoro = "minhoca";
    }
}

class Vertebrado
{
    public Ave ave;
    public Mamifero mamifero;

    public Vertebrado()
    {
        ave = new Ave();
        mamifero = new Mamifero();
    }
}

class Ave
{
    public string carnivoro;
    public string onivoro;

    public Ave()
    {
        carnivoro = "aguia";
        onivoro = "pomba";
    }
}

class Mamifero
{
    public string onivoro;
    public string herbivoro;

    public Mamifero()
    {
        onivoro = "homem";
        herbivoro = "vaca";
    }
}

class Program
{
    static void Main()
    {
        Animal animal = new Animal();

        string prop_1 = Console.ReadLine();
        string prop_2 = Console.ReadLine();
        string prop_3 = Console.ReadLine();

        object currentObject = animal;

        foreach (string propName in new[] { prop_1, prop_2, prop_3 })
        {
            Type type = currentObject.GetType();
            FieldInfo property = type.GetField(propName);

            if (property != null)
            {
                currentObject = property.GetValue(currentObject);
            }
        }
        Console.WriteLine("{0}", currentObject);

    }
}