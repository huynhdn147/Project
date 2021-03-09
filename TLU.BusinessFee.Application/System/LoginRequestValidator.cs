using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Application.System
{
    public class LoginRequestValidator: AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.maNhanVien).NotEmpty().WithMessage(" Ma nhan vien khong duoc de trong");
            RuleFor(x => x.passWord).NotEmpty().WithMessage(" Mat khau khong duoc de trong");
        }
    }
}
