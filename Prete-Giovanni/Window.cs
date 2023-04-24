namespace Prete_Giovanni
{
    /// <summary>
    /// This utility class models the game window.
    /// </summary>
    class Window
    {
        private static Window _instance = null;
        private static object _semaphore = new object();

        private Window() { }

        public static Window Istanza
        {
            get
            {
                lock (_semaphore)
                {
                    if (_instance == null) 
                        _instance = new Window();
                    return _instance;
                }
            }
        }

        /// <summary>
        /// Property to get and set the Width.
        /// </summary>
        public static float Width
        {
            get;
            set;
        }

        /// <summary>
        /// Property to get and set the Height.
        /// </summary>
        public static float Height
        {
            get;
            set;
        }
    }
}
