namespace TestsWithGenerics.Classes.Vehicles
{
    public abstract class Car : Vehicle, ICar
    {
        public virtual int GetNumberOfDoors()
        {
            throw new System.NotImplementedException();
        }
    }

}