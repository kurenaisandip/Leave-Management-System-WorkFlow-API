using Microsoft.AspNetCore.Mvc;

namespace Leave_Management_System_WorkFlow_API.Controller.Login;

[ApiController]
public class LoginController: ControllerBase{


    [HttpPost(Routes.Routes.Login.LoginUser)]
    public async Task<IActionResult> Login([FromBody] LoginRequestDTO loginRequest){
        
        
        return Ok();
    }

}