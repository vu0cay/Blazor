using Microsoft.AspNetCore.Components;

namespace  BlazorApp.Components.Pages;

public class ComputeBase : ComponentBase {
    public int num1 {get; set;}
    public int num2 {get; set;} 
    public int result {get; set;}
    
    public void Form_Calculate() {
        
        result = num1 + num2;
    }
    public void Form_Clear() {
        num1 = 0;
        num2 = 0;
        result = 0;
    }
}