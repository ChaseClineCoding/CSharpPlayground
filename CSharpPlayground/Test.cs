using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPlayground
{
    class Test<TFirst, TSecond>
    {
        public TFirst test1;
        public TSecond test2;

        private string privateString = "This is private";
        protected string protectedString = "This is protected";
        public string publicString = "This is public";
        internal string internalString = "This is internal";
        protected internal string protectedInternalString = "This is protected internal";
        private protected string privateProtectedString = "This is private protected";
    }
}
