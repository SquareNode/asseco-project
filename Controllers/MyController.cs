using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using projekat.Services;

namespace projekat.Controllers {


    [Route("transactions")]
    [ApiController]
    public class MyController : ControllerBase {
        private readonly IImportService import;
        private readonly ILogger<MyController> _logger;
        
        public MyController(IImportService import, ILogger<MyController> logger) {
            this.import = import;
            this._logger = logger;
        }

        [HttpPost("import")]
        public async Task<IActionResult> importTransactions(){
            var result = import.importTx();

            if (result == false)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }

}