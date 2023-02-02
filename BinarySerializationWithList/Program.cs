using BinarySerializationWithList;
using System.Runtime.Serialization.Formatters.Binary;

public class MainClass
{
    static void BinarySerialization(List<Student> myList)
    {

        try
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("C:\\Users\\labuser\\Documents\\productList.txt", FileMode.OpenOrCreate, FileAccess.Write);

            bf.Serialize(fs, myList);
            fs.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    static void BinaryDeserilization()
    {
        List<Student> myList;
        try
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("C:\\Users\\labuser\\Documents\\productList.txt", FileMode.Open, FileAccess.Read);
            myList = (List<Student>)bf.Deserialize(fs);
            fs.Close();
            foreach (Student s in myList)
            {
                Console.WriteLine(s.ID);
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        students.Add(new Student());
        students.Add(new Student());
        students.Add(new Student());
        students.Add(new Student());
        students.Add(new Student());

        BinarySerialization(students);
        BinaryDeserilization();

    }
}
