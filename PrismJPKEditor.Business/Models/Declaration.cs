using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PrismJPKEditor.Business.Models
{

    public class Declaration : BusinessBase
    {
        #region private memmbers
        private IList<DeclarationField> _declarations;

        #endregion

        #region properties


        public IList<DeclarationField> Declarations
        {
            get { return _declarations; }
            set { SetProperty(ref _declarations, value); }
        }

        public override bool HasErrors => Declarations.Any(decl => decl.HasErrors);




        #endregion

        #region constructor



        public Declaration()
        {
            Declarations = new List<DeclarationField>();
        }


        #endregion

        #region private Methods

        //private void CreateDeclarations()
        //{
        //    for (int i = 10; i < 70; i++)
        //    {
        //        var declarationField = new DeclarationField();
        //    }
        //}

        #endregion

    }


}

