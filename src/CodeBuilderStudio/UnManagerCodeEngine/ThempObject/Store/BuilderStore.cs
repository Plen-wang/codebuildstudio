using System;
using System.Collections.Generic;
using System.Text;

namespace UnManagerCodeEngine
{
    /// <summary>
    /// 表示存储过程的代码生成模板对象
    /// </summary>
    public class BuilderStore
    {
        /// <summary>
        /// 存储过程名称
        /// </summary>
        public string StoreProcedureName { get; set; }
        List<BuilderParameter> _parameter;
        public List<BuilderParameter> Parameter
        {
            get
            {
                if (_parameter == null)
                    _parameter = new List<BuilderParameter>();

                return _parameter;
            }
        }
        public void AddParameterList(List<BuilderParameter> parameterlist)
        {
            _parameter = parameterlist;
        }
    }
}
