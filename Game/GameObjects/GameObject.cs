using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Assignment3
{
    public abstract class GameObject : Transformable
    {
        public abstract void Update(float deltaTime);
        public abstract void Draw(RenderWindow window);
    }

    
    
}
