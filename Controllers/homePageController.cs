using System;
using System.Threading.Tasks;
using FindTutor.Models;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using Server;

namespace FindTutor.Controllers
{
   
    public class homePageController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/homePage.cshtml");

        }



        /*public IActionResult setAccountDetails(string firstName, string lastName, string user_Email, string user_Password)
        {
            registrationModel registration_model = new registrationModel();
            
            registration_model.firstName = firstName;
            registration_model.lastName = lastName;
            registration_model.user_Email = user_Email;
            registration_model.user_Password = user_Password;


            Console.WriteLine(registration_model.firstName);
            return View("~/Views/accountView.cshtml",registration_model);

        }*/


        public async Task<IActionResult> showingFromDB(string firstName,string lastName,string  user_Email,string user_Password){

            registrationModel registration_model = new registrationModel();

            /*string firstName="", lastName="",  user_Email="", user_Password="";

            foreach(var x in usr_data){
                firstName = usr_data[0].firstName;
                lastName = usr_data[0].lastName;
                user_Email = usr_data[0].user_Email;
                user_Password = usr_data[0].user_Password;
            }*/

           /* registrationModel registration_model = new registrationModel();
            
            registration_model.firstName = firstName;
            registration_model.lastName = lastName;
            registration_model.user_Email = user_Email;
            registration_model.user_Password = user_Password;*/

            //return View("~/Views/accountView.cshtml",registration_model);
            



            /*bool email_Check = await DAL.IsExist(
                "select user_Email from user_data where user_Email = @email",
                new string[,]{
                    {"@email",email}
                }
            );



            /*if(email_Check){
                return Content("Email Found");
            }
            else{
                return Content("Email Not Found!");
            }*/



            /*bool v = await DataAccessLayer.ExecuteNonQueryAsync(
                        "insert into sessions (user_id, token, created) values (@user_id, @token, @created)",
                        new string[,] {
                            { "@user_id", res[0].user_id },
                            { "@token", token_str },
                            { "@created", MySqlUtility.ConvertTo_MySqlDate(DateTime.Now) }
                        }
                    );*/

            




           // string Id = "4";
            bool usr_data = await DAL.ExecuteNonQueryAsync(
                "insert into user_data (firstName,lastName,user_Email,user_Password) values ( @firstName, @lastName, @user_Email, @user_Password)",
                new string[,] {
                    {"@firstName",firstName},
                    {"@lastName",lastName},
                    {"@user_Email",user_Email},
                    {"@user_Password",user_Password}

                }
            );

            if(usr_data){
                return View("~/Views/accountView.cshtml",registration_model);
            }

            else{
                return Content("Email already in use!");
            }
            

            //return View("~/Views/accountView.cshtml",registration_model);

        }






     
    }
}