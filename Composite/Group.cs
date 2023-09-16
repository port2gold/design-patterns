

namespace design_patterns.Composite
{
    public class Group : Component
    {
        private List<Component> components = new List<Component>();

        public void Add(Component shape)
        {
            components.Add(shape);
        }

        public void Move()
        {
            foreach (Component shape in components)
            {
                shape.Move();
            }
        }

        public void Render()
        {
            foreach (Component component in components)
            {
                component.Render();
            }
        }

    }
}
