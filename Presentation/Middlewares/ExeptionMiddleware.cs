namespace Presentation.Middlewares
{
    public class ExeptionMiddleware
    {
        private readonly RequestDelegate next;

        public ExeptionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public void Invoke(HttpContext context)
        {
        }

    }
}
