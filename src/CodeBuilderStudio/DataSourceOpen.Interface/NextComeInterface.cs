/*
 *author:南京.王清培
 *coding time:2011.5.28
 *copyright:江苏华招网信息技术有限公司
 * *function:该接口为外公开，该接口的父构件未能实现所有的构件功能，所以继续向下传递实现；
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DataSourceOpen.Interface
{
    /// <summary>
    /// 向下传递实现接口，该接口是要对外公开的；
    /// 功能说明：该接口是DataSourceOpen.Come构件的第一层子构件，在父构件中未能实现的功能通过本接口给出；
    /// </summary>
    public interface NextComeInterface
    {

    }
}
