//using Admin.Core.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Admin.Services.Service
//{
//    public class ILkpBaseServices 

//    {
//        readonly private ILkpServices<LineofBusiness> lineofbussiens;
//        readonly private ILkpServices<Language> language;
//        readonly private ILkpServices<Languagelevel> langugelevel;
//        readonly private ILkpServices<Account> account;
//        public ILkpBaseServices( ILkpServices<LineofBusiness> lineofbussiens, ILkpServices<Language> language
//                         ,ILkpServices <Account> account ,ILkpServices<Languagelevel> langugelevel)
//        {
//            this.lineofbussiens = lineofbussiens;
//            this.language = language;
//            this.account = account;
//            this.langugelevel = langugelevel;

//        }

//        public async Task<List<Language>> GetAll()
//        {
//            var getall = await _dbContext.ToListAsync();
//            return getall;
//        }




//    }
//}
