using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class ClassTestContext : DbContext
    {
        public ClassTestContext()
        {
        }

        public ClassTestContext(DbContextOptions<ClassTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<CountQuesTheme> CountQuesThemes { get; set; }
        public virtual DbSet<CountQuestion> CountQuestions { get; set; }
        public virtual DbSet<CountTest> CountTests { get; set; }
        public virtual DbSet<CountTheme> CountThemes { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<LeanPlan> LeanPlans { get; set; }
        public virtual DbSet<MarkTest> MarkTests { get; set; }
        public virtual DbSet<PlanSubject> PlanSubjects { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<ResultTest> ResultTests { get; set; }
        public virtual DbSet<Speciality> Specialities { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<SubBaseQuest> SubBaseQuests { get; set; }
        public virtual DbSet<SubBaseTest> SubBaseTests { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<TeachSub> TeachSubs { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TempAnswer> TempAnswers { get; set; }
        public virtual DbSet<TempQuest> TempQuests { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<TestGroup> TestGroups { get; set; }
        public virtual DbSet<TestKind> TestKinds { get; set; }
        public virtual DbSet<ThemaTest> ThemaTests { get; set; }
        public virtual DbSet<ThemeSub> ThemeSubs { get; set; }
        public virtual DbSet<TrueAn> TrueAns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=ClassTest;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.HasKey(e => new { e.IdQues, e.IdAns })
                    .HasName("PK__Answers__534D60F1");

                entity.Property(e => e.IdQues).HasColumnName("id_ques");

                entity.Property(e => e.IdAns)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("id_ans")
                    .IsFixedLength(true);

                entity.Property(e => e.PictAns)
                    .HasColumnType("image")
                    .HasColumnName("pict_ans");

                entity.Property(e => e.TextA)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("text_a");

                entity.Property(e => e.TextARtf)
                    .HasColumnType("text")
                    .HasColumnName("text_a_rtf");

                entity.HasOne(d => d.IdQuesNavigation)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.IdQues)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Answers__id_ques__5441852A");
            });

            modelBuilder.Entity<CountQuesTheme>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CountQuesTheme");

                entity.Property(e => e.IdSub).HasColumnName("id_sub");

                entity.Property(e => e.IdTheme).HasColumnName("id_theme");

                entity.Property(e => e.Kol).HasColumnName("kol");
            });

            modelBuilder.Entity<CountQuestion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CountQuestion");

                entity.Property(e => e.IdSub).HasColumnName("id_sub");

                entity.Property(e => e.Kol).HasColumnName("kol");
            });

            modelBuilder.Entity<CountTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CountTest");

                entity.Property(e => e.IdSub).HasColumnName("id_sub");

                entity.Property(e => e.Kol).HasColumnName("kol");
            });

            modelBuilder.Entity<CountTheme>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CountTheme");

                entity.Property(e => e.IdSub).HasColumnName("id_sub");

                entity.Property(e => e.Kol).HasColumnName("kol");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.IdDep)
                    .HasName("PK__Departments__76CBA758");

                entity.Property(e => e.IdDep).HasColumnName("id_dep");

                entity.Property(e => e.NameDep)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Name_dep");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(e => e.IdGr)
                    .HasName("PK__groups__060DEAE8");

                entity.ToTable("groups");

                entity.HasIndex(e => e.NameGr, "UQ__groups__07020F21")
                    .IsUnique();

                entity.Property(e => e.IdGr).HasColumnName("id_gr");

                entity.Property(e => e.Curs).HasColumnName("curs");

                entity.Property(e => e.IdSpec).HasColumnName("id_spec");

                entity.Property(e => e.Kol).HasColumnName("kol");

                entity.Property(e => e.NameGr)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("name_gr");

                entity.HasOne(d => d.IdSpecNavigation)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.IdSpec)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__groups__id_spec__07F6335A");
            });

            modelBuilder.Entity<LeanPlan>(entity =>
            {
                entity.HasKey(e => e.IdPlan)
                    .HasName("PK__LeanPlan__09DE7BCC");

                entity.ToTable("LeanPlan");

                entity.Property(e => e.IdPlan).HasColumnName("id_plan");

                entity.Property(e => e.Curs).HasColumnName("curs");

                entity.Property(e => e.IdSpec).HasColumnName("id_spec");

                entity.Property(e => e.NamePlan)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name_plan");

                entity.Property(e => e.Semester).HasColumnName("semester");

                entity.HasOne(d => d.IdSpecNavigation)
                    .WithMany(p => p.LeanPlans)
                    .HasForeignKey(d => d.IdSpec)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LeanPlan__id_spe__0AD2A005");
            });

            modelBuilder.Entity<MarkTest>(entity =>
            {
                entity.HasKey(e => e.IdMark)
                    .HasName("PK__Mark_test__47DBAE45");

                entity.ToTable("Mark_test");

                entity.Property(e => e.IdMark).HasColumnName("id_mark");

                entity.Property(e => e.Bal).HasColumnName("bal");

                entity.Property(e => e.DateTest)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Date_test");

                entity.Property(e => e.IdStud).HasColumnName("id_stud");

                entity.Property(e => e.IdTest).HasColumnName("id_test");

                entity.Property(e => e.KolFalse).HasColumnName("Kol_false");

                entity.Property(e => e.KolHalf).HasColumnName("Kol_half");

                entity.Property(e => e.KolTrue).HasColumnName("Kol_true");

                entity.Property(e => e.PerCent).HasColumnName("per_cent");

                entity.HasOne(d => d.IdStudNavigation)
                    .WithMany(p => p.MarkTests)
                    .HasForeignKey(d => d.IdStud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Mark_test__id_st__48CFD27E");

                entity.HasOne(d => d.IdTestNavigation)
                    .WithMany(p => p.MarkTests)
                    .HasForeignKey(d => d.IdTest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Mark_test__id_te__49C3F6B7");
            });

            modelBuilder.Entity<PlanSubject>(entity =>
            {
                entity.HasKey(e => new { e.IdPlan, e.IdSub })
                    .HasName("PK__PlanSubject__0CBAE877");

                entity.ToTable("PlanSubject");

                entity.Property(e => e.IdPlan).HasColumnName("id_plan");

                entity.Property(e => e.IdSub).HasColumnName("id_sub");

                entity.Property(e => e.Hours).HasColumnName("hours");

                entity.HasOne(d => d.IdPlanNavigation)
                    .WithMany(p => p.PlanSubjects)
                    .HasForeignKey(d => d.IdPlan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PlanSubje__id_pl__0DAF0CB0");

                entity.HasOne(d => d.IdSubNavigation)
                    .WithMany(p => p.PlanSubjects)
                    .HasForeignKey(d => d.IdSub)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PlanSubje__id_su__0EA330E9");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasKey(e => e.IdQues)
                    .HasName("PK__Question__4BAC3F29");

                entity.ToTable("Question");

                entity.Property(e => e.IdQues).HasColumnName("id_ques");

                entity.Property(e => e.IdTheme).HasColumnName("id_theme");

                entity.Property(e => e.IsRtf).HasColumnName("is_rtf");

                entity.Property(e => e.KolTrue).HasColumnName("kol_true");

                entity.Property(e => e.Pict).HasColumnName("pict");

                entity.Property(e => e.Picture)
                    .HasColumnType("image")
                    .HasColumnName("picture");

                entity.Property(e => e.TextQ)
                    .HasMaxLength(1200)
                    .IsUnicode(false)
                    .HasColumnName("text_q");

                entity.Property(e => e.TextQRtf)
                    .HasColumnType("text")
                    .HasColumnName("text_q_rtf");

                entity.HasOne(d => d.IdThemeNavigation)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.IdTheme)
                    .HasConstraintName("FK__Question__id_the__4CA06362");
            });

            modelBuilder.Entity<ResultTest>(entity =>
            {
                entity.HasKey(e => e.IdRez)
                    .HasName("PK__Result_test__01142BA1");

                entity.ToTable("Result_test");

                entity.HasIndex(e => new { e.DateTest, e.IdTest, e.IdStud, e.IdQues }, "UQ__Result_test__02084FDA")
                    .IsUnique();

                entity.Property(e => e.IdRez).HasColumnName("id_rez");

                entity.Property(e => e.AnsQOrder)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("AnsQ_order");

                entity.Property(e => e.Answer)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BalResult)
                    .HasColumnType("numeric(4, 1)")
                    .HasColumnName("Bal_result");

                entity.Property(e => e.DateTest)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Date_test");

                entity.Property(e => e.IdQues).HasColumnName("id_ques");

                entity.Property(e => e.IdStud).HasColumnName("id_stud");

                entity.Property(e => e.IdTest).HasColumnName("id_test");

                entity.HasOne(d => d.IdQuesNavigation)
                    .WithMany(p => p.ResultTests)
                    .HasForeignKey(d => d.IdQues)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Result_te__id_qu__04E4BC85");

                entity.HasOne(d => d.IdStudNavigation)
                    .WithMany(p => p.ResultTests)
                    .HasForeignKey(d => d.IdStud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Result_te__id_st__02FC7413");

                entity.HasOne(d => d.IdTestNavigation)
                    .WithMany(p => p.ResultTests)
                    .HasForeignKey(d => d.IdTest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Result_te__id_te__03F0984C");
            });

            modelBuilder.Entity<Speciality>(entity =>
            {
                entity.HasKey(e => e.IdSpec)
                    .HasName("PK__Speciality__7B905C75");

                entity.ToTable("Speciality");

                entity.HasIndex(e => e.NameSpec, "UQ__Speciality__7C8480AE")
                    .IsUnique();

                entity.Property(e => e.IdSpec).HasColumnName("id_spec");

                entity.Property(e => e.CodeSpec)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("code_spec")
                    .IsFixedLength(true);

                entity.Property(e => e.NameSpec)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name_spec");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.IdStud)
                    .HasName("PK__Students__3D5E1FD2");

                entity.Property(e => e.IdStud).HasColumnName("id_stud");

                entity.Property(e => e.Foto)
                    .HasColumnType("image")
                    .HasColumnName("foto");

                entity.Property(e => e.IdGr).HasColumnName("id_gr");

                entity.Property(e => e.Name1)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("name1");

                entity.Property(e => e.Name2)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("name2");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("number")
                    .IsFixedLength(true);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.YearEnter).HasColumnName("year_enter");

                entity.HasOne(d => d.IdGrNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.IdGr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Students__id_gr__3E52440B");
            });

            modelBuilder.Entity<SubBaseQuest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SubBaseQuest");

                entity.Property(e => e.CountQ).HasColumnName("count_q");

                entity.Property(e => e.CountTh).HasColumnName("count_th");

                entity.Property(e => e.IdSub).HasColumnName("id_sub");

                entity.Property(e => e.NameSub)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("name_sub");

                entity.Property(e => e.ShortNameSub)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("short_name_sub");
            });

            modelBuilder.Entity<SubBaseTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SubBaseTest");

                entity.Property(e => e.CountQ).HasColumnName("count_q");

                entity.Property(e => e.CountT).HasColumnName("count_t");

                entity.Property(e => e.CountTh).HasColumnName("count_th");

                entity.Property(e => e.IdSub).HasColumnName("id_sub");

                entity.Property(e => e.NameSub)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("name_sub");

                entity.Property(e => e.ShortNameSub)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("short_name_sub");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasKey(e => e.IdSub)
                    .HasName("PK__Subject__023D5A04");

                entity.ToTable("Subject");

                entity.HasIndex(e => e.ShortNameSub, "UQ__Subject__03317E3D")
                    .IsUnique();

                entity.HasIndex(e => e.NameSub, "UQ__Subject__0425A276")
                    .IsUnique();

                entity.Property(e => e.IdSub).HasColumnName("id_sub");

                entity.Property(e => e.NameSub)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("name_sub");

                entity.Property(e => e.ShortNameSub)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("short_name_sub");
            });

            modelBuilder.Entity<TeachSub>(entity =>
            {
                entity.HasKey(e => new { e.IdSub, e.IdTeach })
                    .HasName("PK__TeachSub__32E0915F");

                entity.ToTable("TeachSub");

                entity.Property(e => e.IdSub).HasColumnName("id_sub");

                entity.Property(e => e.IdTeach).HasColumnName("id_teach");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.IdSubNavigation)
                    .WithMany(p => p.TeachSubs)
                    .HasForeignKey(d => d.IdSub)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TeachSub__id_sub__34C8D9D1");

                entity.HasOne(d => d.IdTeachNavigation)
                    .WithMany(p => p.TeachSubs)
                    .HasForeignKey(d => d.IdTeach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TeachSub__id_tea__33D4B598");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(e => e.IdTeach)
                    .HasName("PK__Teachers__300424B4");

                entity.Property(e => e.IdTeach).HasColumnName("id_teach");

                entity.Property(e => e.IdDep).HasColumnName("id_dep");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("login");

                entity.Property(e => e.Name1)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("name1");

                entity.Property(e => e.Name2)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("name2");

                entity.Property(e => e.Parol)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("parol");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("surname");

                entity.HasOne(d => d.IdDepNavigation)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.IdDep)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Teachers__id_dep__30F848ED");
            });

            modelBuilder.Entity<TempAnswer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempAnswer");

                entity.Property(e => e.DateTest)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("date_test");

                entity.Property(e => e.IdAns)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("id_ans")
                    .IsFixedLength(true);

                entity.Property(e => e.IdQues).HasColumnName("id_ques");

                entity.Property(e => e.IdStud).HasColumnName("id_stud");

                entity.Property(e => e.IdTest).HasColumnName("id_test");

                entity.Property(e => e.TextA)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("text_a");
            });

            modelBuilder.Entity<TempQuest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempQuest");

                entity.Property(e => e.DateTest)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("date_test");

                entity.Property(e => e.IdQues).HasColumnName("id_ques");

                entity.Property(e => e.IdStud).HasColumnName("id_stud");

                entity.Property(e => e.IdTest).HasColumnName("id_test");

                entity.Property(e => e.IdTheme).HasColumnName("id_theme");

                entity.Property(e => e.KolTrue).HasColumnName("kol_true");

                entity.Property(e => e.Pict).HasColumnName("pict");

                entity.Property(e => e.Picture)
                    .HasColumnType("image")
                    .HasColumnName("picture");

                entity.Property(e => e.TextQ)
                    .HasMaxLength(1200)
                    .IsUnicode(false)
                    .HasColumnName("text_q");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasKey(e => e.IdTest)
                    .HasName("PK__Tests__403A8C7D");

                entity.HasIndex(e => new { e.IdSub, e.NameTest }, "UQ__Tests__412EB0B6")
                    .IsUnique();

                entity.Property(e => e.IdTest).HasColumnName("id_test");

                entity.Property(e => e.IdSub).HasColumnName("id_sub");

                entity.Property(e => e.LengthMin).HasColumnName("Length_min");

                entity.Property(e => e.NameTest)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name_test");

                entity.Property(e => e.Repeat).HasColumnName("repeat");

                entity.HasOne(d => d.IdSubNavigation)
                    .WithMany(p => p.Tests)
                    .HasForeignKey(d => d.IdSub)
                    .HasConstraintName("FK__Tests__id_sub__4222D4EF");
            });

            modelBuilder.Entity<TestGroup>(entity =>
            {
                entity.HasKey(e => new { e.IdTest, e.IdGr })
                    .HasName("PK__Test_group__5DCAEF64");

                entity.ToTable("Test_group");

                entity.Property(e => e.IdTest).HasColumnName("id_test");

                entity.Property(e => e.IdGr).HasColumnName("id_gr");

                entity.Property(e => e.Admission).HasColumnName("admission");

                entity.Property(e => e.Allowed).HasColumnName("allowed");

                entity.Property(e => e.TestBegin)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("test_begin");

                entity.Property(e => e.TestEnd)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("test_end");

                entity.HasOne(d => d.IdGrNavigation)
                    .WithMany(p => p.TestGroups)
                    .HasForeignKey(d => d.IdGr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Test_group__id_gr");

                entity.HasOne(d => d.IdTestNavigation)
                    .WithMany(p => p.TestGroups)
                    .HasForeignKey(d => d.IdTest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Test_group__id_test");
            });

            modelBuilder.Entity<TestKind>(entity =>
            {
                entity.HasKey(e => e.IdKind)
                    .HasName("PK__TestKind__36B12243");

                entity.ToTable("TestKind");

                entity.HasIndex(e => e.NameKind, "UQ__TestKind__37A5467C")
                    .IsUnique();

                entity.Property(e => e.IdKind)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_kind");

                entity.Property(e => e.NameKind)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name_kind");
            });

            modelBuilder.Entity<ThemaTest>(entity =>
            {
                entity.HasKey(e => new { e.IdTest, e.IdTheme })
                    .HasName("PK__Thema_test__440B1D61");

                entity.ToTable("Thema_test");

                entity.Property(e => e.IdTest).HasColumnName("id_test");

                entity.Property(e => e.IdTheme).HasColumnName("id_theme");

                entity.Property(e => e.CountQ).HasColumnName("count_Q");

                entity.Property(e => e.OrderThema).HasColumnName("order_thema");

                entity.HasOne(d => d.IdTestNavigation)
                    .WithMany(p => p.ThemaTests)
                    .HasForeignKey(d => d.IdTest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Thema_tes__id_te__44FF419A");

                entity.HasOne(d => d.IdThemeNavigation)
                    .WithMany(p => p.ThemaTests)
                    .HasForeignKey(d => d.IdTheme)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Thema_tes__id_th__45F365D3");
            });

            modelBuilder.Entity<ThemeSub>(entity =>
            {
                entity.HasKey(e => e.IdTheme)
                    .HasName("PK__Theme_sub__398D8EEE");

                entity.ToTable("Theme_sub");

                entity.Property(e => e.IdTheme).HasColumnName("id_theme");

                entity.Property(e => e.Bal).HasColumnName("bal");

                entity.Property(e => e.IdKind).HasColumnName("id_kind");

                entity.Property(e => e.IdSub).HasColumnName("id_sub");

                entity.Property(e => e.NameTheme)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("name_theme");

                entity.HasOne(d => d.IdKindNavigation)
                    .WithMany(p => p.ThemeSubs)
                    .HasForeignKey(d => d.IdKind)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Theme_sub__id_ki__3B75D760");

                entity.HasOne(d => d.IdSubNavigation)
                    .WithMany(p => p.ThemeSubs)
                    .HasForeignKey(d => d.IdSub)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Theme_sub__id_su__3A81B327");
            });

            modelBuilder.Entity<TrueAn>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.IdQues, e.Ans }, "UQ__TrueAns__123EB7A3")
                    .IsUnique();

                entity.Property(e => e.Ans)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ans");

                entity.Property(e => e.IdQues).HasColumnName("id_ques");

                entity.Property(e => e.PerCent).HasColumnName("per_cent");

                entity.HasOne(d => d.IdQuesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdQues)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TrueAns__id_ques__1332DBDC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
