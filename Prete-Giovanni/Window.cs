namespace Prete_Giovanni
{
    class Window
    {
        private static Window istanza = null;
        private static object semaforo = new object();

        private Window() { }

        public static Window Istanza
        {
            get
            {
                lock (semaforo)
                {
                    if (istanza == null) 
                        istanza = new Window();
                    return istanza;
                }
            }
        }

        public static double Width
        {
            get;
            set;
        }

        public static double Height
        {
            get;
            set;
        }
    }
}
