using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonelName).NotEmpty().WithMessage("Personel İsmi Boş Geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev Kısmını Boş Geçemezsiniz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Yolu Boş Geçilemez");
            RuleFor(x => x.PersonelName).MaximumLength(50).WithMessage("Lütfen 50 Karakterden Daha Az Veri Girişi Yapın");
            RuleFor(x => x.PersonelName).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Bilgi Girişi Yapın");
            RuleFor(x=>x.Title).MaximumLength(50).WithMessage("Lütfen 50 Karakterden Daha Az Veri Girişi Yapın");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen En Az 3 Karakter Bilgi Girişi Yapın");
        }
    }
}
