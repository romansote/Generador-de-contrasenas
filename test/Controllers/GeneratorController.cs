using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using System.Text;
using test.Models;
using Newtonsoft.Json.Bson;
using System.Security.Permissions;

namespace test.Controllers
{
    public class GeneratorController : Controller
    {

        private const string letters = "abcdefghijklmñopqrstuvwxyzABCDEFGHIJKLMÑNOPQRSTUVWXYZ";
        private const string numbers = "1234567890";
        private const string specialCaracteres = "!#$%&()*+,-./:;<=>?@[]^_`{|}~=";


        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(GeneratorModel generatorModel)
        {
            if (!ModelState.IsValid)
            {
                return View(generatorModel);
            }

            ViewBag.Password = generatePassword(generatorModel.Type, generatorModel.Size);
                

            return View(generatorModel);
        }

        private string generatePassword(int type, int size)
        {

            StringBuilder sb = new StringBuilder();

            Random rd = new Random();

            GeneratorModel generateModel = new GeneratorModel();

            switch (type)
            {
                case (int)TypePassword.OnlyAlphaNumeric:

                    string _alphaNumeric = string.Concat(letters, numbers);

                    while (0 < size--)
                    {
                        sb.Append(_alphaNumeric[rd.Next(_alphaNumeric.Length)]);
                    }
                    break;

                case (int)TypePassword.OnlyLetters:

                    while (0 < size--)
                    {
                        sb.Append(letters[rd.Next(letters.Length)]);
                    }
                    break;

                case (int)TypePassword.OnlyNumbers:

                    while (0 < size--)
                    {
                        sb.Append(numbers[rd.Next(numbers.Length)]);
                    }
                    break;

                case (int)TypePassword.AlphanumericAndSpecialSymbols:

                    string _alphaSpecialsCaracteres = string.Concat(specialCaracteres, letters);

                    while (0 < size--)
                    {
                        sb.Append(_alphaSpecialsCaracteres[rd.Next(_alphaSpecialsCaracteres.Length)]);
                    }
                    break;
            }

            return sb.ToString();
        }

    }
}
