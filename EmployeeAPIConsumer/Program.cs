using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPIConsumer
{
    internal class Program
    {
        public static void AddEmployeeAsync(Employee emp)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:50313/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var content1 = "{'Name':'Bhushan3','Salary':1283.94,'DID' :3}";
            String empstr = JsonConvert.SerializeObject(emp);

            var content = new StringContent(empstr, Encoding.UTF8, "application/json");

   
            HttpResponseMessage response = client.PostAsync("api/Employee/AddEmployeeAsync",content).Result;
            
            if (response != null)
            {
                Console.WriteLine(response.ToString());
            }

            /*HttpResponseMessage response = client.PostAsJsonAsync(
       "api/Employee/AddEmployeeAsync", emp).Result;*/

            

           /* response.EnsureSuccessStatusCode();*/

            /*//HTTP POST
            var postTask = client.PostAsJsonAsync<Employee>("api/Employee/Post", emp);
               // postTask.Wait();

                var result = postTask.Result;*/

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Failed");
                }


/*
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:50313/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            
            var task = client.PostAsJsonAsync<Employee>("api/Employee/Post",emp);
            task.Wait();

            var result = task.Result;
            if (result.IsSuccessStatusCode)
            {
                Console.WriteLine(result.Content);

            }
            else
            {
                Console.WriteLine("failed");
            }*/
        }
   

       public static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:50313/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            IEnumerable<Employee> emps = null;

            HttpResponseMessage response = client.GetAsync("api/Employee/get").Result;

            if(response.IsSuccessStatusCode)
            {
                Console.WriteLine("Success");
               // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

                emps = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Employee>>(response.Content.ReadAsStringAsync().Result);

                foreach (Employee emp in emps)
                {
                    Console.WriteLine(emp.Name);

                }
            }
            else
            {
                Console.WriteLine("Failed");
            }
            Employee e =   new Employee();
            e.Name = "trine";
            e.Salary = 347;
            e.DID = 3;

           // AddEmployeeAsync(e);



        }
    }
}
