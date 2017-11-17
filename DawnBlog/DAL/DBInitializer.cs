using DawnBlog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace DawnBlog.DAL
{
    public class DBInitializer : DropCreateDatabaseAlways<DB>
    {
        protected override void Seed(DB context)
        {
            context.BlogPost.AddOrUpdate(
                bp => bp.BlogPost_Id,
                    new BlogPost()
                    {
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                        "Donec rhoncus porttitor pretium. Donec aliquet magna at augue mollis venenatis. " +
                        "Nam tincidunt magna sed nisl fringilla sagittis. Nam scelerisque iaculis diam, " +
                        "ut cursus ligula ornare ac. Integer justo nulla, elementum et dui quis, porttitor " +
                        "tincidunt leo. In vel ex nec libero porta pretium. Duis sollicitudin sit amet velit" +
                        " sit amet tempor. Vestibulum a elit non nibh pharetra sollicitudin. Nulla id pulvinar enim." +
                        " Quisque posuere lacus augue, sit amet accumsan risus pellentesque eget. Donec pellentesque " +
                        "tempus cursus. Nulla eget nisi sed ex egestas eleifend. Proin luctus tortor non lorem volutpat, " +
                        "a ornare felis vehicula. Mauris blandit efficitur diam, vitae aliquet nisi vehicula vitae.",
                        Title = "Lorem100"
                    },
                    new BlogPost()
                    {
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec rhoncus porttitor pretium. " +
                        "Donec aliquet magna at augue mollis venenatis. Nam tincidunt magna sed nisl fringilla sagittis. " +
                        "Nam scelerisque iaculis diam, ut cursus ligula ornare ac. Integer justo nulla, elementum et dui quis, " +
                        "porttitor tincidunt leo. In vel ex nec libero porta pretium. Duis sollicitudin sit amet velit sit amet " +
                        "tempor. Vestibulum a elit non nibh pharetra sollicitudin. Nulla id pulvinar enim. Quisque posuere" +
                        " lacus augue, sit amet accumsan risus pellentesque eget. Donec pellentesque tempus cursus. Nulla " +
                        "eget nisi sed ex egestas eleifend. Proin luctus tortor non lorem volutpat, a ornare felis vehicula." +
                        " Mauris blandit efficitur diam, vitae aliquet nisi vehicula vitae. Aliquam velit nisi, varius pretium " +
                        "lacinia eget, volutpat eu leo.Aenean iaculis diam nec urna dapibus, quis tempus libero pretium.Integer" +
                        " et sodales dui, ut placerat ligula.Duis blandit ante in convallis dignissim.Suspendisse eget massa" +
                        " urna.Nulla facilisi.In facilisis egestas orci, quis vulputate neque varius non.Nullam semper ipsum turpis," +
                        "eu gravida tortor efficitur ac.Morbi dictum finibus congue.Proin volutpat nec risus vitae sagittis.Sed " +
                        "posuere blandit ante, id scelerisque risus auctor quis.Praesent vel nulla quis nisi vehicula dapibus vel " +
                        "rutrum magna.Etiam semper enim.",
                        Title = "Lorem200"
                    },
                    new BlogPost()
                    {
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis erat ligula, malesuada eu " +
                        "felis a, tempor pretium elit. Maecenas bibendum tellus a quam dapibus porttitor. Nullam vel ex " +
                        "vel dui gravida dictum vel non massa. Pellentesque euismod leo vel rhoncus viverra. Suspendisse" +
                        " felis eros, tincidunt vel nibh quis, blandit porta diam. Ut tempor sed leo luctus venenatis." +
                        " Etiam ornare ipsum pretium nulla tempus tincidunt. Donec porttitor sapien id nulla molestie, " +
                        "quis malesuada purus fringilla. Nullam eros erat, porttitor a lorem quis, consectetur luctus dui. " +
                        "Praesent sit amet ligula non massa dapibus accumsan. Nam vehicula ornare mollis. Donec augue " +
                        "felis, elementum id ante at, congue fringilla nisi. Nulla ac tortor sed tellus feugiat porttitor" +
                        " a ut leo. Mauris blandit, ex in tincidunt faucibus, leo diam dignissim leo, a maximus sapien " +
                        "tellus vel urna. Quisque vitae ligula quis arcu rhoncus luctus id id metus. Orci varius natoque " +
                        "penatibus et magnis dis parturient montes, nascetur ridiculus mus. Phasellus finibus aliquet orci, " +
                        "sed tincidunt mauris sodales a. Integer venenatis magna eros, non porttitor justo aliquam ac. " +
                        "Vestibulum at feugiat enim. Sed lacus enim, ultricies id molestie ut, aliquam nec ex. Vestibulum" +
                        " quis laoreet lacus, non auctor arcu. Proin et ex ac ex consectetur malesuada. Maecenas egestas " +
                        "tellus sit amet tortor fringilla maximus. Cras vulputate vulputate mi, eu vestibulum nulla " +
                        "malesuada at. Donec sed ligula ultrices est tincidunt eleifend. Vivamus justo diam, vehicula " +
                        "sit amet augue eget, pellentesque semper mi. Praesent nulla leo, tincidunt eu enim sed, vestibulum " +
                        "sollicitudin lorem. Maecenas ac mi convallis, consectetur purus eget, auctor velit. Morbi ut " +
                        "euismod lorem. Etiam ullamcorper, risus lobortis pellentesque posuere, leo sapien fringilla quam, " +
                        "euismod rhoncus nulla leo et ex. Phasellus malesuada sed odio eget vehicula. Donec et nisl sit " +
                        "amet tortor imperdiet rhoncus sed in justo. Curabitur non ultricies magna. Nunc pretium arcu ac lacinia.",
                        Title = "Lorem300"
                    }
                    
                );
            base.Seed(context);
        }
    }
}