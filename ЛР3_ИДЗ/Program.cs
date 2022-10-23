using ЛР3_ИДЗ_LIB;
namespace LR3_IDZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(4, 4);
            Matrix.PrintMatrix(matrix);
            Matrix.GetStrMin(matrix);
            Matrix.PrintResultMatrix(matrix);
        }
    }
}