namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
        /*  Use el patron Polimorfismo porque en este programa el comportamiento  variaba según el tipo, en este caso 
            destination en AllInPrinter.
        */
    }
}