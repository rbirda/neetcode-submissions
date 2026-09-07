public class Singleton {
    private static Singleton uniqueInstance = null;
    private static readonly object lockObject = new object();
    private string mode;

    private Singleton() {
      this.mode = "testMode";
    }

    public static Singleton getInstance() {
        if(uniqueInstance == null)
        {
            lock(lockObject)
            {
                if(uniqueInstance == null)
                {
                    uniqueInstance = new Singleton();
                }
            }

        }
    return uniqueInstance;
    }

    public string getValue() {
         return mode;
    }

    public void setValue(string value){

         lock(lockObject)
            {
                this.mode = value;
            }


    }
}
