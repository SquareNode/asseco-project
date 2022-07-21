using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using projekat.Services;
using projekat.Models;

namespace projekat.Controllers {


    [Route("transactions")]
    [ApiController]
    public class TransactionController : ControllerBase {
        private readonly ITransactionService transactionService;
        private readonly ILogger<TransactionController> _logger;
        
        public TransactionController(ITransactionService transactionService, ILogger<TransactionController> logger) {
            this.transactionService = transactionService;
            this._logger = logger;
        }

        [HttpPost("import")]
        public async Task<IActionResult> importTransactions(){
            var result = await transactionService.importTx();

            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> getTransactions([FromQuery] string startdate,
        [FromQuery] string enddate) {
            //TODO filter startdate enddate
            var result = await transactionService.getTransactions();
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
           
        }
        [HttpPost("{id}/categorize")]
        public async Task<IActionResult> categorizeTransaction() {
            var result = await transactionService.categorizeTransaction();
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
        [HttpPost("{id}/split")]
        public async Task<IActionResult> splitTransaction() {
            var result = await transactionService.splitTransaction();
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }

}