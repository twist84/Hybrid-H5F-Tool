using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hybrid_H5F_Tool
{
    class Program
    {
        static void Main(string[] args)
        {
            FormRunner Form = new FormRunner();
            if (AllocConsole())
            {
                while (true)
                {
                    Console.Out.WriteLine("Type FOV, FPS, RES.");
                    string UserInput = Console.In.ReadLine();

                    switch (UserInput.ToLower())
                    {
                        case "fov":
                            Form.Run("fov");
                            break;
                        case "fps":
                            Form.Run("fps");
                            break;
                        case "res":
                            Form.Run("res");
                            /*
                             * Setting resolution is fine but setting aspect-ratio is not 
                             * (it uses 1.777777791[16:9] only so setting it to anything else I.E. 1.6[16:10] fucks it up)
                             */
                            break;
                        case "map":
                            Form.Run("map");
                            break;
                        case "exit":
                            goto Exit;
                    }
                }
                Exit:
                FreeConsole();
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();
    }

    class FormRunner
    {
        public void Run(string form)
        {
            Application.EnableVisualStyles();

            switch (form)
            {
                case "fov":
                    Application.Run(new Form_FOV());
                    break;
                case "fps":
                    Application.Run(new Form_FPS());
                    break;
                case "res":
                    Application.Run(new Form_RES());
                    break;
                case "map":
                    Application.Run(new Form_MAP());
                    break;
            }
        }

        public bool isGameRunning()
        {
            Process[] pname = Process.GetProcessesByName("halo5forge");
            return (pname.Length != 0);
        }
    }
}
