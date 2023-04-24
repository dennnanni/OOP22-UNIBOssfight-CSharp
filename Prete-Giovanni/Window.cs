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

        public static float Width
        {
            get;
            set;
        }

        public static float Height
        {
            get;
            set;
        }
    }
}
