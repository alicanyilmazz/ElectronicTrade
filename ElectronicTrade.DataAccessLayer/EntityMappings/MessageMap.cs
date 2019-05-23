using ElectronicTrade.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.DataAccessLayer.EntityMappings
{
    class MessageMap: EntityTypeConfiguration<Message>
    {
        public MessageMap()
        {
            this.ToTable("Messages", "ETrade");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Id).HasColumnOrder(0);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Subject).HasColumnName("Subject");
            this.Property(x => x.Subject).HasColumnOrder(1);
            this.Property(x => x.Subject).IsOptional();
            this.Property(x => x.Subject).HasMaxLength(40);

            this.Property(x => x.Text).HasColumnName("Text");
            this.Property(x => x.Text).HasColumnOrder(2);
            this.Property(x => x.Text).IsOptional();
            this.Property(x => x.Text).HasMaxLength(300);

            this.Property(x => x.UserBy).HasColumnName("UserBy");
            this.Property(x => x.UserBy).HasColumnOrder(3);
            this.Property(x => x.UserBy).IsRequired();
            this.Property(x => x.UserBy).HasMaxLength(25);

            this.Property(x => x.IsRead).HasColumnName("IsRead");
            this.Property(x => x.IsRead).HasColumnOrder(4);
            this.Property(x => x.IsRead).IsRequired();

            this.Property(x => x.Member_From_Id).HasColumnName("Member_From_Id");
            this.Property(x => x.Member_From_Id).HasColumnOrder(5);
            this.Property(x => x.Member_From_Id).IsOptional();

            this.Property(x => x.Member_To_Id).HasColumnName("Member_To_Id");
            this.Property(x => x.Member_To_Id).HasColumnOrder(6);
            this.Property(x => x.Member_To_Id).IsOptional();

            this.Property(x => x.Parent_Message_Id).HasColumnName("Parent_Message_Id");
            this.Property(x => x.Parent_Message_Id).HasColumnOrder(7);
            this.Property(x => x.Parent_Message_Id).IsOptional();

            this.Property(x => x.AddedDate).HasColumnName("AddedDate");
            this.Property(x => x.AddedDate).HasColumnOrder(8);
            this.Property(x => x.AddedDate).IsOptional();
            this.Property(x => x.AddedDate).HasColumnType("datetime2");

            this.Property(x => x.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(x => x.ModifiedDate).HasColumnOrder(9);
            this.Property(x => x.ModifiedDate).IsOptional();
            this.Property(x => x.ModifiedDate).HasColumnType("datetime2");

            //Bir Member a birden fazla gelen incoming mesaj alabilir.Bir incoming mesaj bir bir Member 'a ait olabilir.
            this.HasOptional(x => x.takedmember)
              .WithMany(y => y.incomingmessages)
              .HasForeignKey(x => x.Member_From_Id).WillCascadeOnDelete(false);

            //Bir Member a birden fazla outgoingmessages mesaj gönderilebilir.Bir outgoingmessages mesaj bir Member tarafından gönderilmiş olabilir.
            this.HasOptional(x => x.sendedmember)
             .WithMany(y => y.outgoingmessages)
             .HasForeignKey(x => x.Member_To_Id).WillCascadeOnDelete(false);

            //Bir Message in bir parent mesaji olabilir.Ama birden fazla sub Messag 'i olabilir.
            this.HasOptional(x => x.message)
            .WithMany(y => y.messages)
            .HasForeignKey(x => x.Parent_Message_Id).WillCascadeOnDelete(false);
        }
    }
}
