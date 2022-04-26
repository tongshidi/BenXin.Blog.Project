using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenXin.Blog.Project.Model.Entities.User
{
    /// <summary>
    /// �û���
    /// </summary>
    [SugarTable("CoreCmsUser", TableDescription = "�û���")]
    public partial class UserModel
    {
        /// <summary>
        /// �û���
        /// </summary>
        public UserModel()
        {
        }

        /// <summary>
        /// �û�ID
        /// </summary>
        [Display(Name = "�û�ID")]
        [SugarColumn(ColumnDescription = "�û�ID", IsPrimaryKey = true, IsIdentity = true)]
        [Required(ErrorMessage = "������{0}")]
        public System.Int32 id { get; set; }
        /// <summary>
        /// �û���
        /// </summary>
        [Display(Name = "�û���")]
        [SugarColumn(ColumnDescription = "�û���", IsNullable = true)]
        [StringLength(20, ErrorMessage = "��{0}�����ܳ���{1}�ַ�����")]
        public System.String userName { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [Display(Name = "����")]
        [SugarColumn(ColumnDescription = "����", IsNullable = true)]
        [StringLength(50, ErrorMessage = "��{0}�����ܳ���{1}�ַ�����")]
        public System.String passWord { get; set; }
        /// <summary>
        /// �ֻ���
        /// </summary>
        [Display(Name = "�ֻ���")]
        [SugarColumn(ColumnDescription = "�ֻ���", IsNullable = true)]
        [StringLength(15, ErrorMessage = "��{0}�����ܳ���{1}�ַ�����")]
        public System.String mobile { get; set; }
        /// <summary>
        /// �Ա�[1��2Ů3δ֪]
        /// </summary>
        [Display(Name = "�Ա�[1��2Ů3δ֪]")]
        [SugarColumn(ColumnDescription = "�Ա�[1��2Ů3δ֪]")]
        [Required(ErrorMessage = "������{0}")]
        public System.Int32 sex { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [Display(Name = "����")]
        [SugarColumn(ColumnDescription = "����", IsNullable = true)]
        public System.DateTime? birthday { get; set; }
        /// <summary>
        /// ͷ��
        /// </summary>
        [Display(Name = "ͷ��")]
        [SugarColumn(ColumnDescription = "ͷ��", IsNullable = true)]
        [StringLength(255, ErrorMessage = "��{0}�����ܳ���{1}�ַ�����")]
        public System.String avatarImage { get; set; }
        /// <summary>
        /// �ǳ�
        /// </summary>
        [Display(Name = "�ǳ�")]
        [SugarColumn(ColumnDescription = "�ǳ�", IsNullable = true)]
        [StringLength(50, ErrorMessage = "��{0}�����ܳ���{1}�ַ�����")]
        public System.String nickName { get; set; }
        /// <summary>
        /// ���
        /// </summary>
        [Display(Name = "���")]
        [SugarColumn(ColumnDescription = "���")]
        [Required(ErrorMessage = "������{0}")]
        public System.Decimal balance { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [Display(Name = "����")]
        [SugarColumn(ColumnDescription = "����")]
        [Required(ErrorMessage = "������{0}")]
        public System.Int32 point { get; set; }
        /// <summary>
        /// �û��ȼ�
        /// </summary>
        [Display(Name = "�û��ȼ�")]
        [SugarColumn(ColumnDescription = "�û��ȼ�")]
        [Required(ErrorMessage = "������{0}")]
        public System.Int32 grade { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [Display(Name = "����ʱ��")]
        [SugarColumn(ColumnDescription = "����ʱ��")]
        [Required(ErrorMessage = "������{0}")]
        public System.DateTime createTime { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [Display(Name = "����ʱ��")]
        [SugarColumn(ColumnDescription = "����ʱ��", IsNullable = true)]
        public System.DateTime? updataTime { get; set; }
        /// <summary>
        /// ״̬[1����2ͣ��]
        /// </summary>
        [Display(Name = "״̬[1����2ͣ��]")]
        [SugarColumn(ColumnDescription = "״̬[1����2ͣ��]")]
        [Required(ErrorMessage = "������{0}")]
        public System.Int32 status { get; set; }
        /// <summary>
        /// �Ƽ���
        /// </summary>
        [Display(Name = "�Ƽ���")]
        [SugarColumn(ColumnDescription = "�Ƽ���")]
        [Required(ErrorMessage = "������{0}")]
        public System.Int32 parentId { get; set; }
        /// <summary>
        /// ���������˻�
        /// </summary>
        [Display(Name = "���������˻�")]
        [SugarColumn(ColumnDescription = "���������˻�")]
        [Required(ErrorMessage = "������{0}")]
        public System.Int32 userWx { get; set; }
        /// <summary>
        /// ɾ����־ �����ݾ���ɾ��
        /// </summary>
        [Display(Name = "ɾ����־ �����ݾ���ɾ��")]
        [SugarColumn(ColumnDescription = "ɾ����־ �����ݾ���ɾ��")]
        [Required(ErrorMessage = "������{0}")]
        public System.Boolean isDelete { get; set; }
    }
}
