using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Assignment3
{
    public class Player : GameObject
    {
        private Sprite playerSprite;
        private const int PLAYER_TILTING_X = 10;
        private const int PLAYER_TILTING_Y = 8;

        private const float MOVE_SPEED = 100.0f;

        private readonly float animationSpeed = 8;
        private readonly int[] animationTypeFramesCount =
        {
            3,
            3,
            1,
            3,
            10,
            10,
            10,
            10
        };
        private AnimationType currentAnimation = AnimationType.IdleDown;
        private float animationTimeIndex;

        private Vector2f position;

        public Vector2f Position
        {
            get { return position; }
            set
            {
                position = value;
                playerSprite.Position = position;
            }
        }

        public Player(Texture texture, Vector2f startPosition)
        {
            playerSprite = new Sprite(texture);
            playerSprite.Scale = new Vector2f(1.0f, 1.0f);
            Position = startPosition;

            playerSprite.TextureRect = new IntRect(0, 0, playerSprite.TextureRect.Width / PLAYER_TILTING_X,
                playerSprite.TextureRect.Height / PLAYER_TILTING_Y);
        }

        public override void Update(float deltaTime)
        {
            OrientationAwareRunToIdle();
            PlayerMovement(deltaTime);
            DoSpriteAnimation();

            animationTimeIndex += deltaTime * animationSpeed;
            InputManager.Instance.Update();
        }

        public override void Draw(RenderWindow window)
        {
            // Draw the outline
            DebugDraw.DrawRectOutline(new IntRect((int)Position.X, (int)Position.Y, playerSprite.TextureRect.Width, playerSprite.TextureRect.Height), Color.Red);

            // Draw the player sprite
            playerSprite.Position = Position;
            window.Draw(playerSprite);
        }

        private void OrientationAwareRunToIdle()
        {
            if (currentAnimation == AnimationType.RunUp)
                currentAnimation = AnimationType.IdleUp;
            if (currentAnimation == AnimationType.RunDown)
                currentAnimation = AnimationType.IdleDown;
            if (currentAnimation == AnimationType.RunLeft)
                currentAnimation = AnimationType.IdleLeft;
            if (currentAnimation == AnimationType.RunRight)
                currentAnimation = AnimationType.IdleRight;
        }

        private void PlayerMovement(float deltaTime)
        {
            // Get input
            if (InputManager.Instance.GetKeyPressed(Keyboard.Key.W))
            {
                currentAnimation = AnimationType.RunUp;
                Position -= new Vector2f(0, 1) * MOVE_SPEED * deltaTime;
            }

            if (InputManager.Instance.GetKeyPressed(Keyboard.Key.A))
            {
                currentAnimation = AnimationType.RunLeft;
                Position -= new Vector2f(1, 0) * MOVE_SPEED * deltaTime;
            }

            if (InputManager.Instance.GetKeyPressed(Keyboard.Key.S))
            {
                currentAnimation = AnimationType.RunDown;
                Position += new Vector2f(0, 1) * MOVE_SPEED * deltaTime;
            }

            if (InputManager.Instance.GetKeyPressed(Keyboard.Key.D))
            {
                currentAnimation = AnimationType.RunRight;
                Position += new Vector2f(1, 0) * MOVE_SPEED * deltaTime;
            }
        }

        private void DoSpriteAnimation()
        {
            var animationFrame = (int)animationTimeIndex % animationTypeFramesCount[(int)currentAnimation];
            playerSprite.TextureRect = new IntRect(animationFrame * playerSprite.TextureRect.Width,
                (int)currentAnimation * playerSprite.TextureRect.Height, playerSprite.TextureRect.Width, playerSprite.TextureRect.Height);
        }
    }
}
