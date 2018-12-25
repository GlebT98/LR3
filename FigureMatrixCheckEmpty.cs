using LR2;

namespace LR3
{
    class FigureMatrixCheckEmpty : IMatrixCheckEmpty<Figure>
    {
        public Figure getEmptyElement() => null;

        public bool checkEmptyElement(Figure element) => element == null;

        //Figure IMatrixCheckEmpty<Figure>.getEmptyElement()
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
