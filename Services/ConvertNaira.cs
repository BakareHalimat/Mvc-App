using Halimat.Interface;
using Halimat.Models;

namespace Halimat.Services
{
    public class ConvertNaira : IConvertToDollars
    {
        public int Convertnaira(CalculateDollar model)
        {
            return int.Parse(model.Naira) / 432;
        }
    }
}