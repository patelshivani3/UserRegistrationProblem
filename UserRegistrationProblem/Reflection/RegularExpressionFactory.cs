using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem.Reflection
{
    public class RegularExpressionFactory
    {
        public object CreateRegularExpression(string className, string constructor)
        {
            //UserRegistrationProblem.RegularExpression
            string pattern = "." + constructor + "$";
            bool result = Regex.IsMatch(className, pattern);
            if (result)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type regularExpressionType = assembly.GetType(className);
                    return Activator.CreateInstance(regularExpressionType);
                }
                catch (Exception)
                {
                    throw new CustomRegularExpressionException("Class not found", CustomRegularExpressionException.ExceptionTypes.CLASS_NOT_FOUND);
                }
            }
            else
            {
                throw new CustomRegularExpressionException("Constructor not found", CustomRegularExpressionException.ExceptionTypes.NO_SUCH_METHOD);
            }
        }
    }
}
