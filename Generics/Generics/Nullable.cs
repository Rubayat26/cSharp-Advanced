namespace Generics
{
    public class Nullable<T> where T : struct    
    {
        private object _value;     // here the value is of type object as we dont know
                                   //which kind of value would be passed  
                                   // value type can be double float whatever 
        public Nullable()
        {
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        
        /*
        public void Whatever()
        {
            var k = 2;           // we can create variables inside a method
        }
        */
        
        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value; // here we are casting  the object value to the T 
                                  // It is safe as we are already passing the T type 
                                  //value in the constructor

            return default(T);  //default keyword is used to return the default value  
        }
    }
}


// in C# value type cannot be null
// In this class we are trying the give our value types to become Nullable property 