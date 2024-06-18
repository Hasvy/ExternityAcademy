using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorApp.Components.Pages
{
    public partial class Counter : ComponentBase
    {
        //[Parameter] public EventCallback OnOperationExecuted { get; set; }
        public Stack<string> results = new Stack<string>();
        private int currentCount = 0;
        private int operand = 0;
        private delegate int MathOperation();

        private void IncrementCount()
        {
            currentCount++;
        }

        private async Task MathOperationExecute(MathOperation mathOperation)
        {
            int result = mathOperation();
            currentCount = result;
            //await OnOperationExecuted.InvokeAsync();
            //results.Add(result);
            //await Task.Delay(1);
        }

        private int Sum()
        {
            int result = currentCount + operand;
            results.Push($"{currentCount} + {operand} = {result}");
            return result;
        }

        private int Subtraction()
        {
            int result = currentCount - operand;
            results.Push($"{currentCount} - {operand} = {result}");
            return result;
        }

        private int Divide()
        {
            int result = currentCount / operand;
            results.Push($"{currentCount} / {operand} = {result}");
            return result;
        }

        private int Multiply()
        {
            int result = currentCount * operand;
            results.Push($"{currentCount} * {operand} = {result}");
            return result;
        }
    }
}
