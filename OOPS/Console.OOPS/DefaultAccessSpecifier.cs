using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.OOPS
{
    /// <summary>
    /// SUMMARY
    /// 1. Non-nested types, enumeration and delegate accessibilities (may only have internal or public accessibility)
    ///                      | Default   | Permitted declared accessibilities
    /// ------------------------------------------------------------------
    /// namespace            | public    | none(always implicitly public)
    /// enum                 | public    | none(always implicitly public)
    /// interface            | internal  | public, internal
    /// class                | internal  | public, internal
    /// struct               | internal  | public, internal
    /// delegate             | internal  | public, internal
    /// 
    /// 2. Nested type and member accessiblities
    ///                      | Default   | Permitted declared accessibilities
    /// ------------------------------------------------------------------
    /// namespace            | public    | none(always implicitly public)
    /// enum                 | public    | none(always implicitly public)
    /// interface            | public    | none
    /// class                | private   | All¹
    /// struct               | private   | public, internal, private²
    /// delegate             | private   | All¹
    /// constructor          | private   | All¹
    /// interface member     | public    | none(always implicitly public)
    /// method               | private   | All¹
    /// field                | private   | All¹
    /// user-defined operator | none      | public (must be declared public)
    /// 
    /// </summary>
    class DefaultAccessSpecifier
    {
    }

    enum COLORS {
        R =1,
        G =2, 
        B = 3
    }
}
