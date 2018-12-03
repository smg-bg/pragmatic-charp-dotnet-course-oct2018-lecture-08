
namespace ClassesAndObjects
{
    public class Desk
    {
        public int Size;

        internal string _myPrivateSerialNumber = "00000";

        public Desk()
        {
            _myPrivateSerialNumber = "77777";
        }

        public override string ToString()
        {
            return $"Desk No: {_myPrivateSerialNumber}";
        }
    }
}
