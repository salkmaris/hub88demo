﻿using Microsoft.AspNetCore.Mvc;
using WalletApi.DTOs;
using WalletApi.Services;

namespace WalletApi.Controllers
{
    [ApiController]
    [Route("transaction")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        private readonly IUserService _userService;
        
        public TransactionController(ITransactionService transactionService, IUserService userService)
        {
            _transactionService = transactionService;
            _userService = userService;
        }

        [HttpPost("win")]
        public ActionResult<UserBalanceDto> TransactionWin([FromBody] TransactionWinDto transactionWinDto)
        {
            var response = _transactionService.IncreaseUserBalance(transactionWinDto);

            return _userService.GetUserBalance(new RequestUserInfoDto
            {
                RequestUuid = transactionWinDto.RequestUuid, 
                UserName = transactionWinDto.UserName
            }, response);
        }

        [HttpPost("bet")]
        public ActionResult<UserBalanceDto> TransactionBet([FromBody] TransactionBetDto transactionBetDto)
        {
            var response = _transactionService.DecreaseUserBalance(transactionBetDto);
            
            return _userService.GetUserBalance(new RequestUserInfoDto
                {
                    RequestUuid = transactionBetDto.RequestUuid, 
                    UserName = transactionBetDto.UserName
                }, response);
        }

        [HttpPost("rollback")]
        public ActionResult<UserBalanceDto> TransactionRollback(TransactionRollbackDto transactionRollbackDto)
        {
            var response = _transactionService.RollbackTransaction(transactionRollbackDto);
            
            return _userService.GetUserBalance(new RequestUserInfoDto
                {
                    RequestUuid = transactionRollbackDto.RequestUuid, 
                    UserName = transactionRollbackDto.UserName
                }, response);
        }
    }
}