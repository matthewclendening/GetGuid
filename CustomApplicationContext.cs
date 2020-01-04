using System.Windows.Forms;

namespace GetGuid
{
    public class CustomApplicationContext : ApplicationContext
    {
        private readonly GetGuidController _controller;

        public CustomApplicationContext()
        {
            _controller = new GetGuidController(this);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_controller != null)
                {
                    _controller.Dispose();
                }
            }
        }
    }
}