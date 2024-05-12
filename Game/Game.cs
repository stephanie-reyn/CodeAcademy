using SFML.Window;
using SFML.Graphics;
using SFML.System;
using System.Diagnostics;


namespace Assignment3
{
    public class Game
    {
        private const int WINDOW_WIDTH = 800;
        private const int WINDOW_HEIGHT = 600;
        private const string WINDOW_TITLE = "Assignment 3";
        private RenderWindow window;
        private readonly VideoMode mode = new(WINDOW_WIDTH, WINDOW_HEIGHT);
        private readonly Clock clock = new();
        private View view;

        public Game()
        {
            window = new RenderWindow(mode, WINDOW_TITLE);
            window.Resized += (sender, args) =>
            {
                // Set the origin and center of the view to the top-left corner of the window
                View view = new View(new Vector2f(args.Width / 2f, args.Height / 2f), new Vector2f(args.Width, args.Height));
                window.SetView(view);
            };

            window.Closed += OnWindowClosePressed;

            // Initially set the view to match the window size with origin at top-left
            view = new View(new Vector2f(WINDOW_WIDTH / 2f, WINDOW_HEIGHT / 2f), new Vector2f(WINDOW_WIDTH, WINDOW_HEIGHT));
            window.SetView(view);

            DebugDraw.ActiveWindow = window;
        }



        public void Initialize()
        {
        }

        public void Update(float deltaTime)
        {
        }

        public void Run()
        {
            while (window.IsOpen)
            {
                var deltaTime = clock.Restart().AsSeconds();
                HandleEvent();
                Update(deltaTime);
                Draw();

            }
        }

        public void HandleEvent()
        {
            window.DispatchEvents();
        }
        public void Draw()
        {
            window.Clear(Color.Blue);
            DebugDraw.DrawFloor(new Vector2f(0, 0), new Vector2i(20, 20), new Vector2i(50, 50));

            window.Display();
        }

        private void OnWindowClosePressed(object sender, EventArgs e)
        {
            CloseGame();
        }

        private void CloseGame()
        {
            window?.Close();
        }

    }
}