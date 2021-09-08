using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TesteEF
{
    public partial class PortalCNHContext : DbContext
    {
        public PortalCNHContext()
        {
        }

        public PortalCNHContext(DbContextOptions<PortalCNHContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acesso> Acessos { get; set; }
        public virtual DbSet<Atendente> Atendentes { get; set; }
        public virtual DbSet<BaseHumana> BaseHumanas { get; set; }
        public virtual DbSet<Chatbot> Chatbots { get; set; }
        public virtual DbSet<ChatbotFlow> ChatbotFlows { get; set; }
        public virtual DbSet<Contato> Contatos { get; set; }
        public virtual DbSet<Equipe> Equipes { get; set; }
        public virtual DbSet<Flow> Flows { get; set; }
        public virtual DbSet<HistoricoAtendimento> HistoricoAtendimentos { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<MensagensEnviada> MensagensEnviadas { get; set; }
        public virtual DbSet<MensagensRecebida> MensagensRecebidas { get; set; }
        public virtual DbSet<Metrica> Metricas { get; set; }
        public virtual DbSet<NotaAtendimento> NotaAtendimentos { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TempoAtendimento> TempoAtendimentos { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<TicketsProcessado> TicketsProcessados { get; set; }
        public virtual DbSet<UsuarioLogin> UsuarioLogins { get; set; }
        public virtual DbSet<UsuariosAtivo> UsuariosAtivos { get; set; }
        public virtual DbSet<UsuariosEngajado> UsuariosEngajados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("User ID=Mestre ;Password=123456;Initial Catalog=PortalCNH;Data Source=DESKTOP-9RKMNSO\\SQLEXPRESS");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Acesso>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.Property(e => e.Contato)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.DataUpdate).HasColumnType("datetime");

                entity.Property(e => e.NomeChatBot)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Atendente>(entity =>
            {
                entity.HasKey(e => new { e.AutoId, e.PeriodoInicial, e.PeriodoFinal, e.Nome });

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.PeriodoInicial).HasColumnType("date");

                entity.Property(e => e.PeriodoFinal).HasColumnType("date");

                entity.Property(e => e.Nome)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DataUpdate).HasColumnType("datetime");

                entity.Property(e => e.MediaTempoAtendimento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MediaTempoEspera)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MediaTempoPrimeiraResposta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MediaTempoResposta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeChatBot)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BaseHumana>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.ToTable("BaseHumana");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.DataUpdate).HasColumnType("datetime");

                entity.Property(e => e.NomeChatBot)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeContato)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NotaAtendimento)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Chatbot>(entity =>
            {
                entity.HasKey(e => new { e.AutoId, e.Id, e.AuthorizationKey });

                entity.ToTable("Chatbot");

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .HasColumnName("ID");

                entity.Property(e => e.AuthorizationKey).HasMaxLength(100);

                entity.Property(e => e.Grupo).HasMaxLength(100);

                entity.Property(e => e.Nacionalidade)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NomeBase)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RouterAuthorizationKey).HasMaxLength(100);
            });

            modelBuilder.Entity<ChatbotFlow>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.ToTable("ChatbotFlow");

                entity.Property(e => e.DataBackup).HasColumnType("date");

                entity.Property(e => e.DataUpdate).HasColumnType("datetime");

                entity.Property(e => e.Flow).IsUnicode(false);

                entity.Property(e => e.NomeChatbot)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contato>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.Property(e => e.Acesso).HasColumnType("date");

                entity.Property(e => e.DataUpdate).HasColumnType("datetime");

                entity.Property(e => e.Marca)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Equipe>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.HasIndex(e => new { e.PeriodoInicial, e.Nome, e.NomeChatbot }, "IX_Equipes")
                    .IsUnique();

                entity.Property(e => e.DataUpdate).HasColumnType("datetime");

                entity.Property(e => e.MediaTempoAtendimento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MediaTempoEspera)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MediaTempoPrimeiraResposta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MediaTempoResposta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeChatbot)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoFinal).HasColumnType("date");

                entity.Property(e => e.PeriodoInicial).HasColumnType("date");
            });

            modelBuilder.Entity<Flow>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.DataUpdate).HasColumnType("datetime");

                entity.Property(e => e.Menu)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NomeChatBot)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoricoAtendimento>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.ToTable("HistoricoAtendimento");

                entity.Property(e => e.AgenteAtendimento)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CanalOrigem)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DataHoraAbertura).HasColumnType("datetime");

                entity.Property(e => e.DataHoraFechamento).HasColumnType("datetime");

                entity.Property(e => e.EmailHistorico)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("emailHistorico");

                entity.Property(e => e.NomeChatbot)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeContato)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tag)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TimeAtendimento)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasKey(e => new { e.AutoId, e.Data });

                entity.ToTable("Log");

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Aplicacao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Mensagem).IsRequired();

                entity.Property(e => e.Metodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.NomeChatbot)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.UsuarioLogin)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MensagensEnviada>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.HasIndex(e => new { e.IntervalStart, e.IntervalEnd, e.NomeChatBot }, "IMsgEnviada")
                    .IsUnique();

                entity.Property(e => e.DataUpdate).HasColumnType("datetime");

                entity.Property(e => e.IntervalEnd).HasColumnType("date");

                entity.Property(e => e.IntervalStart).HasColumnType("date");

                entity.Property(e => e.NomeChatBot)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MensagensRecebida>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.HasIndex(e => new { e.IntervalStart, e.IntervalEnd, e.NomeChatBot }, "IMsgRecebida")
                    .IsUnique();

                entity.Property(e => e.DataUpdate).HasColumnType("datetime");

                entity.Property(e => e.IntervalEnd).HasColumnType("date");

                entity.Property(e => e.IntervalStart).HasColumnType("date");

                entity.Property(e => e.NomeChatBot)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Metrica>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.DataUpdate).HasColumnType("datetime");

                entity.Property(e => e.NomeChatBot)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NotaAtendimento>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.ToTable("NotaAtendimento");

                entity.HasIndex(e => new { e.DataUpdate, e.NomeChatBot, e.DataAtendimento }, "INota")
                    .IsUnique();

                entity.Property(e => e.DataAtendimento).HasColumnType("date");

                entity.Property(e => e.DataUpdate).HasColumnType("datetime");

                entity.Property(e => e.NomeChatBot)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.ToTable("Tag");

                entity.HasIndex(e => new { e.DataUpdate, e.PeriodoInicial, e.PeriodoFinal }, "IX_Tag")
                    .IsUnique();

                entity.Property(e => e.DataUpdate).HasColumnType("datetime");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.NomeChatBot)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoFinal).HasColumnType("date");

                entity.Property(e => e.PeriodoInicial).HasColumnType("date");
            });

            modelBuilder.Entity<TempoAtendimento>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.ToTable("TempoAtendimento");

                entity.HasIndex(e => e.PeriodoInicial, "IX_TempoAtendimento_1")
                    .IsUnique();

                entity.HasIndex(e => e.PeriodoFinal, "IX_TempoAtendimento_2")
                    .IsUnique();

                entity.Property(e => e.DataUpdate).HasColumnType("datetime");

                entity.Property(e => e.NomeChatBot)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoFinal).HasColumnType("date");

                entity.Property(e => e.PeriodoInicial).HasColumnType("date");

                entity.Property(e => e.TempoAtendimento1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TempoAtendimento");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.HasIndex(e => new { e.Data, e.NomeChatBot }, "IX_Tickets")
                    .IsUnique();

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.DataUpdate).HasColumnType("datetime");

                entity.Property(e => e.NomeChatBot)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TicketsProcessado>(entity =>
            {
                entity.HasKey(e => new { e.AutoId, e.Data })
                    .HasName("PK_TicketsProc");

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.KeyChatbot)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NomeChatbot)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UsuarioLogin>(entity =>
            {
                entity.HasKey(e => new { e.AutoId, e.Usuario, e.Senha })
                    .HasName("PK_Login");

                entity.ToTable("UsuarioLogin");

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();

                entity.Property(e => e.Usuario).HasMaxLength(50);

                entity.Property(e => e.Senha).HasMaxLength(15);

                entity.Property(e => e.Aplicacao).HasMaxLength(50);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<UsuariosAtivo>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.HasIndex(e => new { e.IntervalStart, e.IntervalEnd, e.NomeChatBot }, "IUsuAtivo")
                    .IsUnique();

                entity.Property(e => e.DataUpdate).HasColumnType("datetime");

                entity.Property(e => e.IntervalEnd).HasColumnType("date");

                entity.Property(e => e.IntervalStart).HasColumnType("date");

                entity.Property(e => e.NomeChatBot)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsuariosEngajado>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.HasIndex(e => new { e.IntervalStart, e.IntervalEnd, e.NomeChatBot }, "IUsuEngajado")
                    .IsUnique();

                entity.Property(e => e.DataUpdate).HasColumnType("datetime");

                entity.Property(e => e.IntervalEnd).HasColumnType("date");

                entity.Property(e => e.IntervalStart).HasColumnType("date");

                entity.Property(e => e.NomeChatBot)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
