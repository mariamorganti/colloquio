using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace colloquio.Models;

public partial class GestionematerialitaContext : DbContext
{
    string connectionString = "";

    // Leggi il valore della chiave Connectionstring
    
    public GestionematerialitaContext()
    {

        var configuration = new ConfigurationBuilder()
                //.SetBasePath(AppContext.BaseDirectory)
                //.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
         connectionString = configuration.GetValue<string>("Connectionstring");
    }

    public GestionematerialitaContext(DbContextOptions<GestionematerialitaContext> options)
        : base(options)
    {
       

    }

    public virtual DbSet<AFasiProduzione> AFasiProduziones { get; set; }

    public virtual DbSet<ASottocategorieFasiProduzione> ASottocategorieFasiProduziones { get; set; }

    public virtual DbSet<ATipologicaDocumentiCampiDocumentoProduzione> ATipologicaDocumentiCampiDocumentoProduziones { get; set; }

    public virtual DbSet<ATipologicaDocumentiProduzione> ATipologicaDocumentiProduziones { get; set; }

    public virtual DbSet<Accessi> Accessis { get; set; }

    public virtual DbSet<AltriFiltri> AltriFiltris { get; set; }

    public virtual DbSet<AnagraficaUffici> AnagraficaUfficis { get; set; }

    public virtual DbSet<AnomalieBustum> AnomalieBusta { get; set; }

    public virtual DbSet<ArchivioStampe> ArchivioStampes { get; set; }

    public virtual DbSet<BusteBackOffice> BusteBackOffices { get; set; }

    public virtual DbSet<BusteEccezioni> BusteEccezionis { get; set; }

    public virtual DbSet<BusteOperatore> BusteOperatores { get; set; }

    public virtual DbSet<BusteOperatoreHistory> BusteOperatoreHistories { get; set; }

    public virtual DbSet<CFasiCollaudo> CFasiCollaudos { get; set; }

    public virtual DbSet<CSottocategorieFasiCollaudo> CSottocategorieFasiCollaudos { get; set; }

    public virtual DbSet<CTipologicaDocumentiCampiDocumentoCollaudo> CTipologicaDocumentiCampiDocumentoCollaudos { get; set; }

    public virtual DbSet<CTipologicaDocumentiCollaudo> CTipologicaDocumentiCollaudos { get; set; }

    public virtual DbSet<CausaleNoPresenzaTitolare> CausaleNoPresenzaTitolares { get; set; }

    public virtual DbSet<Causali> Causalis { get; set; }

    public virtual DbSet<CausaliRicevute> CausaliRicevutes { get; set; }

    public virtual DbSet<Configuration> Configurations { get; set; }

    public virtual DbSet<Configurazione> Configuraziones { get; set; }

    public virtual DbSet<ControlliBustaTemporanea> ControlliBustaTemporaneas { get; set; }

    public virtual DbSet<ControlliBustum> ControlliBusta { get; set; }

    public virtual DbSet<DocumentiBusteBackOffice> DocumentiBusteBackOffices { get; set; }

    public virtual DbSet<EsenzioniVema> EsenzioniVemas { get; set; }

    public virtual DbSet<EventiBustaBackOffice> EventiBustaBackOffices { get; set; }

    public virtual DbSet<EventiBustaEccezione> EventiBustaEcceziones { get; set; }

    public virtual DbSet<EventiBustaOperatore> EventiBustaOperatores { get; set; }

    public virtual DbSet<EventiControlloBustum> EventiControlloBusta { get; set; }

    public virtual DbSet<EventiRicevutaBustaOperatore> EventiRicevutaBustaOperatores { get; set; }

    public virtual DbSet<EventiScatola> EventiScatolas { get; set; }

    public virtual DbSet<Fasi> Fasis { get; set; }

    public virtual DbSet<FormattazioneFasiGectnew> FormattazioneFasiGectnews { get; set; }

    public virtual DbSet<Frazionari> Frazionaris { get; set; }

    public virtual DbSet<FrazionariConoVisibilitum> FrazionariConoVisibilita { get; set; }

    public virtual DbSet<Giornaledifondo> Giornaledifondos { get; set; }

    public virtual DbSet<Glossario> Glossarios { get; set; }

    public virtual DbSet<Inc200> Inc200s { get; set; }

    public virtual DbSet<Messaggi> Messaggis { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    public virtual DbSet<MoniSintOffl> MoniSintOffls { get; set; }

    public virtual DbSet<MonitoringBuste> MonitoringBustes { get; set; }

    public virtual DbSet<MonitoringScatole> MonitoringScatoles { get; set; }

    public virtual DbSet<Operazioni> Operazionis { get; set; }

    public virtual DbSet<OperazioniOtp> OperazioniOtps { get; set; }

    public virtual DbSet<OperazioniRicevute> OperazioniRicevutes { get; set; }

    public virtual DbSet<OperazioniStorico> OperazioniStoricos { get; set; }

    public virtual DbSet<ResponseRicercheStoriche> ResponseRicercheStoriches { get; set; }

    public virtual DbSet<RicercheStoriche> RicercheStoriches { get; set; }

    public virtual DbSet<RicevuteBustaOperatore> RicevuteBustaOperatores { get; set; }

    public virtual DbSet<RicevuteBustaOperatoreHistory> RicevuteBustaOperatoreHistories { get; set; }

    public virtual DbSet<Ritm0757720Inc03620891> Ritm0757720Inc03620891s { get; set; }

    public virtual DbSet<Rollout> Rollouts { get; set; }

    public virtual DbSet<Scatole> Scatoles { get; set; }

    public virtual DbSet<ScatoleAvezzano> ScatoleAvezzanos { get; set; }

    public virtual DbSet<SottocategorieFasi> SottocategorieFasis { get; set; }

    public virtual DbSet<StatisticheKafka> StatisticheKafkas { get; set; }

    public virtual DbSet<StruttureLogistiche> StruttureLogistiches { get; set; }

    public virtual DbSet<SvecchiamentoLog> SvecchiamentoLogs { get; set; }

    public virtual DbSet<SysRicercheOperazioni> SysRicercheOperazionis { get; set; }

    public virtual DbSet<Tbanaope> Tbanaopes { get; set; }

    public virtual DbSet<Tbcatope> Tbcatopes { get; set; }

    public virtual DbSet<TblProdottiFake> TblProdottiFakes { get; set; }

    public virtual DbSet<Test> Tests { get; set; }

    public virtual DbSet<TestTabellaEsiti> TestTabellaEsitis { get; set; }

    public virtual DbSet<TestTabellaStati> TestTabellaStatis { get; set; }

    public virtual DbSet<TipologicaCampiDocumento> TipologicaCampiDocumentos { get; set; }

    public virtual DbSet<TipologicaDocumenti> TipologicaDocumentis { get; set; }

    public virtual DbSet<TipologicaDocumentiCampiDocumento> TipologicaDocumentiCampiDocumentos { get; set; }

    public virtual DbSet<Tracce> Tracces { get; set; }

    public virtual DbSet<TracceHistory> TracceHistories { get; set; }

    public virtual DbSet<Ufficio> Ufficios { get; set; }

    public virtual DbSet<ValoriBusteCampiDocumento> ValoriBusteCampiDocumentos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       
        //if (connectionString == null || connectionString.IsNullOrEmpty())
        //optionsBuilder.UseSqlServer("Server= LAPTOP-U3V5I2SM\\SQLEXPRESS;Database=gestionematerialita;Trusted_Connection=True;TrustServerCertificate=True;");
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<AFasiProduzione>(entity =>
        {
            entity.HasKey(e => new { e.CodiceFase, e.VersSoftInizio }).HasName("PK_Fasi_Produzione");

            entity.ToTable("A_Fasi_Produzione");

            entity.Property(e => e.CodiceFase)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ClasseDocumentaleGect)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ClasseDocumentaleGECT");
            entity.Property(e => e.ClasseDocumentaleGectcontroTransazione)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ClasseDocumentaleGECTControTransazione");
            entity.Property(e => e.CodiceFormaTecnica1)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CodiceFormaTecnica2)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.DataFineValidita).HasColumnType("datetime");
            entity.Property(e => e.DataInizioValidita).HasColumnType("datetime");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FattoreScalaStampa).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TabellaAcbWeb).HasMaxLength(10);
            entity.Property(e => e.Tipologia)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Titolo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ASottocategorieFasiProduzione>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("A_SottocategorieFasi_Produzione");

            entity.Property(e => e.CodiceFase)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodiceFormaTecnica1)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CodiceFormaTecnica2)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.ObbligoFormeTecniche)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SottocategoriaFase)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)");
        });

        modelBuilder.Entity<ATipologicaDocumentiCampiDocumentoProduzione>(entity =>
        {
            entity.HasKey(e => new { e.NomeDocumento, e.NomeCampo }).HasName("PK_ElencoDocumentiClassificati_Produzione");

            entity.ToTable("A_TipologicaDocumentiCampiDocumento_Produzione");

            entity.Property(e => e.NomeDocumento)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NomeCampo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ordine).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<ATipologicaDocumentiProduzione>(entity =>
        {
            entity.HasKey(e => e.NomeDocumento).HasName("PK_Documenti_new__Produzione");

            entity.ToTable("A_TipologicaDocumenti_Produzione");

            entity.Property(e => e.NomeDocumento)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Descrizione).IsUnicode(false);
            entity.Property(e => e.FineValidita).HasColumnType("datetime");
            entity.Property(e => e.InizioValidita).HasColumnType("datetime");
            entity.Property(e => e.Tipo)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Accessi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Accessi");

            entity.Property(e => e.NoteProfilo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Ruolo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Visibilita)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AltriFiltri>(entity =>
        {
            entity.HasKey(e => e.IdAltriFiltri).HasName("PK__AltriFil__E8E8330F4AD5F908");

            entity.ToTable("AltriFiltri");

            entity.Property(e => e.FormaTecnica1).IsUnicode(false);
            entity.Property(e => e.ImportoComplessivo).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ImportoComplessivoA).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ImportoComplessivoDa).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Pdl)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PDL");
            entity.Property(e => e.ProgressivoOperazione)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UtenzaOperatore)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IdRicercaNavigation).WithMany(p => p.AltriFiltris).HasForeignKey(d => d.IdRicerca);
        });

        modelBuilder.Entity<AnagraficaUffici>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AnagraficaUffici");

            entity.Property(e => e.AccessoSoloAutorizzati)
                .HasMaxLength(255)
                .HasColumnName("Accesso Solo autorizzati");
            entity.Property(e => e.BancaMezzogiorno)
                .HasMaxLength(255)
                .HasColumnName("Banca Mezzogiorno");
            entity.Property(e => e.CanaleDiVendita)
                .HasMaxLength(255)
                .HasColumnName("Canale di Vendita");
            entity.Property(e => e.Cap)
                .HasMaxLength(255)
                .HasColumnName("CAP");
            entity.Property(e => e.CapoluogoProvincia)
                .HasMaxLength(255)
                .HasColumnName("Capoluogo/Provincia");
            entity.Property(e => e.ClassZonaDiServizio)
                .HasMaxLength(255)
                .HasColumnName("Class Zona di Servizio");
            entity.Property(e => e.CodComune)
                .HasMaxLength(255)
                .HasColumnName("Cod#Comune");
            entity.Property(e => e.CodiceIstat)
                .HasMaxLength(255)
                .HasColumnName("Codice Istat");
            entity.Property(e => e.Comune).HasMaxLength(255);
            entity.Property(e => e.Cre)
                .HasMaxLength(255)
                .HasColumnName("CRE");
            entity.Property(e => e.DataIscrCamCom)
                .HasMaxLength(255)
                .HasColumnName("Data Iscr# Cam# Com#");
            entity.Property(e => e.DescrUbicazione)
                .HasMaxLength(255)
                .HasColumnName("Descr# Ubicazione");
            entity.Property(e => e.DescrizioneDepositoTerritoriale)
                .HasMaxLength(255)
                .HasColumnName("Descrizione Deposito Territoriale");
            entity.Property(e => e.Fax).HasMaxLength(255);
            entity.Property(e => e.Filiale).HasMaxLength(255);
            entity.Property(e => e.Frazionario).HasMaxLength(255);
            entity.Property(e => e.FrazionarioDepositoTerritoriale)
                .HasMaxLength(255)
                .HasColumnName("Frazionario Deposito Territoriale");
            entity.Property(e => e.IdMa)
                .HasMaxLength(255)
                .HasColumnName("ID MA");
            entity.Property(e => e.IdMercato)
                .HasMaxLength(255)
                .HasColumnName("ID Mercato");
            entity.Property(e => e.IdZona)
                .HasMaxLength(255)
                .HasColumnName("ID Zona");
            entity.Property(e => e.Idfil)
                .HasMaxLength(255)
                .HasColumnName("IDFIL");
            entity.Property(e => e.InAppoggio)
                .HasMaxLength(255)
                .HasColumnName("In Appoggio");
            entity.Property(e => e.Indirizzo).HasMaxLength(255);
            entity.Property(e => e.InizioAttivita)
                .HasColumnType("datetime")
                .HasColumnName("Inizio Attivita");
            entity.Property(e => e.IscrizioneCamCom)
                .HasMaxLength(255)
                .HasColumnName("Iscrizione Cam#Com#");
            entity.Property(e => e.Localita).HasMaxLength(255);
            entity.Property(e => e.MacroArea).HasMaxLength(255);
            entity.Property(e => e.Mercato).HasMaxLength(255);
            entity.Property(e => e.OrariMese)
                .HasMaxLength(255)
                .HasColumnName("Orari Mese");
            entity.Property(e => e.PoloSatelliteMercato)
                .HasMaxLength(255)
                .HasColumnName("Polo/Satellite Mercato");
            entity.Property(e => e.PoloSatelliteZona)
                .HasMaxLength(255)
                .HasColumnName("Polo/Satellite Zona");
            entity.Property(e => e.Regione).HasMaxLength(255);
            entity.Property(e => e.RuoloMaster)
                .HasMaxLength(255)
                .HasColumnName("Ruolo Master");
            entity.Property(e => e.RuoloOperation)
                .HasMaxLength(255)
                .HasColumnName("Ruolo Operation");
            entity.Property(e => e.SalaGec)
                .HasMaxLength(255)
                .HasColumnName("Sala Gec");
            entity.Property(e => e.SantoPatrono)
                .HasColumnType("datetime")
                .HasColumnName("Santo Patrono");
            entity.Property(e => e.SiglaProv)
                .HasMaxLength(255)
                .HasColumnName("Sigla Prov#");
            entity.Property(e => e.SportelliGec)
                .HasMaxLength(255)
                .HasColumnName("Sportelli Gec");
            entity.Property(e => e.Stato).HasMaxLength(255);
            entity.Property(e => e.Telefono).HasMaxLength(255);
            entity.Property(e => e.TipoUp).HasMaxLength(255);
            entity.Property(e => e.Ubicazione).HasMaxLength(255);
            entity.Property(e => e.Ufficio).HasMaxLength(255);
            entity.Property(e => e.Zona).HasMaxLength(255);
        });

        modelBuilder.Entity<AnomalieBustum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Anomalie__3214EC070E73E3A3");

            entity.HasIndex(e => e.IdBusta, "IX_AnomalieBusta_IdBusta");

            entity.HasIndex(e => new { e.IdBusta, e.IdControllo }, "IX_AnomalieBusta_IdBusta_IdControllo");

            entity.HasIndex(e => e.IdControllo, "IX_AnomalieBusta_IdControllo");

            entity.Property(e => e.CodiceFase)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodiceOperatore)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CodicePdL)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DataCreazione)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Frazionario)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.IdBusta)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IdControllo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Importo).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Motivazione).IsUnicode(false);
            entity.Property(e => e.Titolo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ArchivioStampe>(entity =>
        {
            entity.HasKey(e => e.IdOperaz).HasName("PK__ARCHIVIO__2A253B7268617B2D");

            entity.ToTable("ARCHIVIO_STAMPE", "SDP2");

            entity.Property(e => e.IdOperaz)
                .ValueGeneratedNever()
                .HasColumnName("ID_OPERAZ");
            entity.Property(e => e.ProgAnnu)
                .HasColumnType("decimal(5, 0)")
                .HasColumnName("PROG_ANNU");
            entity.Property(e => e.Xml)
                .HasMaxLength(3770)
                .IsUnicode(false)
                .HasColumnName("XML");
        });

        modelBuilder.Entity<BusteBackOffice>(entity =>
        {
            entity.HasKey(e => e.IdBusta);

            entity.ToTable("BusteBackOffice");

            entity.HasIndex(e => e.IdScatola, "IX_BusteBackOffice_IdScatola");

            entity.HasIndex(e => new { e.Stato, e.DataContabile }, "IX_BusteBackOffice_Stato_DataContabile");

            entity.Property(e => e.IdBusta)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodiceOperatore)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.CodiceOperatoreApertura)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CodiceOperatoreModifica)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DataApertura)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataChiusura).HasColumnType("datetime");
            entity.Property(e => e.DataContabile)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataCreazione)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Frazionario)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.IdScatola)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Stato)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Unknown");
        });

        modelBuilder.Entity<BusteEccezioni>(entity =>
        {
            entity.HasKey(e => e.IdBusta);

            entity.ToTable("BusteEccezioni");

            entity.HasIndex(e => new { e.Stato, e.DataContabile }, "IX_BusteEccezioni_Stato_DataContabile");

            entity.Property(e => e.IdBusta)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodiceOperatore)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.CodiceOperatoreApertura)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CodiceOperatoreModifica)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DataApertura)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataChiusura).HasColumnType("datetime");
            entity.Property(e => e.DataContabile)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataCreazione)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Frazionario)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.IdScatola)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Stato)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Unknown");
        });

        modelBuilder.Entity<BusteOperatore>(entity =>
        {
            entity.HasKey(e => new { e.IdBusta, e.DataApertura });

            entity.ToTable("BusteOperatore");

            entity.HasIndex(e => new { e.DataApertura, e.Frazionario, e.CodiceOperatore }, "IX_BusteOperatore_Frazionario_CodiceOperatore");

            entity.HasIndex(e => new { e.DataApertura, e.IdScatola }, "IX_BusteOperatore_IdScatola");

            entity.Property(e => e.IdBusta)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DataApertura)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CodiceOperatore)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CodiceOperatoreChiusura)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CodiceOperatoreModifica)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DataAssociazione).HasColumnType("datetime");
            entity.Property(e => e.DataChiusura).HasColumnType("datetime");
            entity.Property(e => e.DataContabile).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.DataCreazione)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataRitrovamento).HasColumnType("datetime");
            entity.Property(e => e.DataSmarrimento).HasColumnType("datetime");
            entity.Property(e => e.DataUltimoControllo).HasColumnType("datetime");
            entity.Property(e => e.Frazionario)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.IdScatola)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Stato)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Unknown");
        });

        modelBuilder.Entity<BusteOperatoreHistory>(entity =>
        {
            entity.HasKey(e => new { e.IdBusta, e.DataApertura });

            entity.ToTable("BusteOperatore_History");

            entity.Property(e => e.IdBusta)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DataApertura)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CodiceOperatore)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CodiceOperatoreChiusura)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CodiceOperatoreModifica)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DataAssociazione).HasColumnType("datetime");
            entity.Property(e => e.DataChiusura).HasColumnType("datetime");
            entity.Property(e => e.DataContabile).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.DataCreazione)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataRitrovamento).HasColumnType("datetime");
            entity.Property(e => e.DataSmarrimento).HasColumnType("datetime");
            entity.Property(e => e.DataUltimoControllo).HasColumnType("datetime");
            entity.Property(e => e.Frazionario)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.IdScatola)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Stato)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Unknown");
        });

        modelBuilder.Entity<CFasiCollaudo>(entity =>
        {
            entity.HasKey(e => new { e.CodiceFase, e.VersSoftInizio }).HasName("PK_Fasi_Collaudo");

            entity.ToTable("C_Fasi_Collaudo");

            entity.Property(e => e.CodiceFase)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ClasseDocumentaleGect)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ClasseDocumentaleGECT");
            entity.Property(e => e.ClasseDocumentaleGectcontroTransazione)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ClasseDocumentaleGECTControTransazione");
            entity.Property(e => e.CodiceFormaTecnica1)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CodiceFormaTecnica2)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.DataFineValidita).HasColumnType("datetime");
            entity.Property(e => e.DataInizioValidita).HasColumnType("datetime");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FattoreScalaStampa).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TabellaAcbWeb).HasMaxLength(10);
            entity.Property(e => e.Tipologia)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Titolo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CSottocategorieFasiCollaudo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("C_SottocategorieFasi_Collaudo");

            entity.Property(e => e.CodiceFase)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodiceFormaTecnica1)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CodiceFormaTecnica2)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.ObbligoFormeTecniche)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SottocategoriaFase)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)");
        });

        modelBuilder.Entity<CTipologicaDocumentiCampiDocumentoCollaudo>(entity =>
        {
            entity.HasKey(e => new { e.NomeDocumento, e.NomeCampo }).HasName("PK_ElencoDocumentiClassificati_Collaudo");

            entity.ToTable("C_TipologicaDocumentiCampiDocumento_Collaudo");

            entity.Property(e => e.NomeDocumento)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NomeCampo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ordine).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<CTipologicaDocumentiCollaudo>(entity =>
        {
            entity.HasKey(e => e.NomeDocumento).HasName("PK_Documenti_new_Collaudo");

            entity.ToTable("C_TipologicaDocumenti_Collaudo");

            entity.Property(e => e.NomeDocumento)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Descrizione).IsUnicode(false);
            entity.Property(e => e.FineValidita).HasColumnType("datetime");
            entity.Property(e => e.InizioValidita).HasColumnType("datetime");
            entity.Property(e => e.Tipo)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CausaleNoPresenzaTitolare>(entity =>
        {
            entity.HasKey(e => e.Codice);

            entity.ToTable("CausaleNoPresenzaTitolare");

            entity.Property(e => e.Codice)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descrizione)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Causali>(entity =>
        {
            entity.HasKey(e => e.IdCausale).HasName("PK__Causali__ACD5CEC0A5012F8E");

            entity.ToTable("Causali");

            entity.Property(e => e.IdCausale)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodiceFase)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descrizione).IsUnicode(false);
            entity.Property(e => e.FineValidita)
                .HasDefaultValue(new DateTime(2999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.InizioValidita)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<CausaliRicevute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Causali___3214EC0705443174");

            entity.ToTable("Causali_Ricevute");

            entity.Property(e => e.IdCausale)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IdControllo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NoteConformita)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Configuration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Configur__3214EC07599889A6");

            entity.ToTable("Configurations", "DemRic");

            entity.Property(e => e.SvecchiamentoDays).HasColumnName("Svecchiamento_Days");
        });

        modelBuilder.Entity<Configurazione>(entity =>
        {
            entity.HasKey(e => e.Chiave);

            entity.ToTable("Configurazione");

            entity.Property(e => e.Chiave)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descrizione).IsUnicode(false);
            entity.Property(e => e.Valore)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ControlliBustaTemporanea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ControlliBustaTemporanea");

            entity.Property(e => e.Frazionario)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.IdBusta)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IdControllo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ControlliBustum>(entity =>
        {
            entity.HasKey(e => e.IdControllo);

            entity.HasIndex(e => e.Frazionario, "IX_ControlliBusta_Frazionario");

            entity.HasIndex(e => e.IdBusta, "IX_ControlliBusta_IdBusta");

            entity.HasIndex(e => e.Tipologia, "nci_msft_1_ControlliBusta_FC8E971D0F1DDF74623E8148FDBC4144");

            entity.HasIndex(e => new { e.CodiceOperatore, e.Frazionario }, "nci_wi_ControlliBusta_D887B927A0DC38E6957954B3BDC3165A");

            entity.Property(e => e.IdControllo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CausaleMancanzaContraddittorio).IsUnicode(false);
            entity.Property(e => e.CodiceOperatore)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CodiceOperatoreEsecuzione)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DataCreazione)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataEsecuzione).HasColumnType("datetime");
            entity.Property(e => e.DataModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Frazionario)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.IdBusta)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Note).IsUnicode(false);
            entity.Property(e => e.Stato)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Tipologia)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DocumentiBusteBackOffice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Document__3214EC07C4EDBB3F");

            entity.ToTable("DocumentiBusteBackOffice");

            entity.Property(e => e.DataInserimento).HasColumnType("datetime");
            entity.Property(e => e.IdBusta)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NomeDocumento)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EsenzioniVema>(entity =>
        {
            entity.HasKey(e => e.CodiceOperatore);

            entity.ToTable("EsenzioniVEMA");

            entity.Property(e => e.CodiceOperatore)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EventiBustaBackOffice>(entity =>
        {
            entity.HasKey(e => new { e.IdBusta, e.DataEvento });

            entity.ToTable("EventiBustaBackOffice");

            entity.HasIndex(e => e.IdBusta, "IX_EventiBustaBackOffice_IdBusta");

            entity.Property(e => e.IdBusta)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DataEvento)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CodiceOperatore)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DescrizioneErrore).IsUnicode(false);
            entity.Property(e => e.Evento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Metadati).IsUnicode(false);
            entity.Property(e => e.StatoFinale)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StatoIniziale)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EventiBustaEccezione>(entity =>
        {
            entity.HasKey(e => new { e.IdBusta, e.DataEvento });

            entity.ToTable("EventiBustaEccezione");

            entity.HasIndex(e => e.IdBusta, "IX_EventiBustaEccezione_IdBusta");

            entity.Property(e => e.IdBusta)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DataEvento)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CodiceOperatore)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DescrizioneErrore).IsUnicode(false);
            entity.Property(e => e.Evento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Metadati).IsUnicode(false);
            entity.Property(e => e.StatoFinale)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StatoIniziale)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EventiBustaOperatore>(entity =>
        {
            entity.HasKey(e => new { e.IdBusta, e.DataEvento });

            entity.ToTable("EventiBustaOperatore");

            entity.HasIndex(e => e.IdBusta, "IX_EventiBustaOperatore_IdBusta");

            entity.Property(e => e.IdBusta)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DataEvento)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CodiceOperatore)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DescrizioneErrore).IsUnicode(false);
            entity.Property(e => e.Evento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Metadati).IsUnicode(false);
            entity.Property(e => e.StatoFinale)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StatoIniziale)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EventiControlloBustum>(entity =>
        {
            entity.HasKey(e => new { e.IdControllo, e.DataEvento });

            entity.HasIndex(e => e.IdControllo, "IX_EventiControlloBusta_IdControllo");

            entity.Property(e => e.IdControllo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DataEvento)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CodiceOperatore)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DescrizioneErrore).IsUnicode(false);
            entity.Property(e => e.Evento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Metadati).IsUnicode(false);
            entity.Property(e => e.MonitoringStorico).HasDefaultValue(false);
            entity.Property(e => e.StatoFinale)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StatoIniziale)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EventiRicevutaBustaOperatore>(entity =>
        {
            entity.HasKey(e => new { e.CodiceOperazione, e.DataEvento });

            entity.ToTable("EventiRicevutaBustaOperatore");

            entity.HasIndex(e => e.CodiceOperazione, "IX_EventiRicevutaBustaOperatore_CodiceOperazione");

            entity.Property(e => e.DataEvento)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CodiceOperatore)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DescrizioneErrore).IsUnicode(false);
            entity.Property(e => e.Evento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Metadati).IsUnicode(false);
            entity.Property(e => e.StatoFinale)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StatoIniziale)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EventiScatola>(entity =>
        {
            entity.HasKey(e => new { e.IdScatola, e.DataEvento });

            entity.ToTable("EventiScatola");

            entity.HasIndex(e => e.IdScatola, "IX_EventiScatola_IdScatola");

            entity.Property(e => e.IdScatola)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DataEvento)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CodiceOperatore)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DescrizioneErrore).IsUnicode(false);
            entity.Property(e => e.Evento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Metadati).IsUnicode(false);
            entity.Property(e => e.MonitoringStorico).HasDefaultValue(false);
            entity.Property(e => e.StatoFinale)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StatoIniziale)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Fasi>(entity =>
        {
            entity.HasKey(e => new { e.CodiceFase, e.VersSoftInizio });

            entity.ToTable("Fasi");

            entity.Property(e => e.CodiceFase)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ClasseDocumentaleGect)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ClasseDocumentaleGECT");
            entity.Property(e => e.ClasseDocumentaleGectcontroTransazione)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ClasseDocumentaleGECTControTransazione");
            entity.Property(e => e.CodiceFormaTecnica1)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CodiceFormaTecnica2)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.DataFineValidita).HasColumnType("datetime");
            entity.Property(e => e.DataInizioValidita).HasColumnType("datetime");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FattoreScalaStampa).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TabellaAcbWeb).HasMaxLength(10);
            entity.Property(e => e.Tipologia)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Titolo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FormattazioneFasiGectnew>(entity =>
        {
            entity.HasKey(e => e.CodiceFase);

            entity.ToTable("FormattazioneFasiGECTNEW");

            entity.Property(e => e.CodiceFase)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Formattazione)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NoteTipoCluster)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Frazionari>(entity =>
        {
            entity.HasKey(e => e.Codice).HasName("PK__Fraziona__0636EC1C15BB612D");

            entity.ToTable("Frazionari");

            entity.Property(e => e.Codice)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.DataCreazione)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataUltimoControllo).HasColumnType("datetime");
            entity.Property(e => e.Descrizione).IsUnicode(false);
            entity.Property(e => e.FlagControlloAutomatico)
                .IsRequired()
                .HasDefaultValueSql("('0')");
        });

        modelBuilder.Entity<FrazionariConoVisibilitum>(entity =>
        {
            entity.HasKey(e => e.Codice).HasName("PK__Fraziona__0636EC1C4D33683F");

            entity.Property(e => e.Codice)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.DataCreazione)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Descrizione).IsUnicode(false);
            entity.Property(e => e.IdFiliale)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.IdMacroArea)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Giornaledifondo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("giornaledifondo");

            entity.Property(e => e.CdBanca)
                .HasMaxLength(255)
                .HasColumnName("CD_BANCA");
            entity.Property(e => e.CdCanale)
                .HasMaxLength(255)
                .HasColumnName("CD_CANALE");
            entity.Property(e => e.CdDivUic)
                .HasMaxLength(255)
                .HasColumnName("CD_DIV_UIC");
            entity.Property(e => e.CdFil)
                .HasMaxLength(255)
                .HasColumnName("CD_FIL");
            entity.Property(e => e.CdModifCommiss)
                .HasMaxLength(255)
                .HasColumnName("CD_MODIF_COMMISS");
            entity.Property(e => e.CdModifValuta)
                .HasMaxLength(255)
                .HasColumnName("CD_MODIF_VALUTA");
            entity.Property(e => e.CdNdgRelCli)
                .HasMaxLength(255)
                .HasColumnName("CD_NDG_REL_CLI");
            entity.Property(e => e.CdOperat)
                .HasMaxLength(255)
                .HasColumnName("CD_OPERAT");
            entity.Property(e => e.CdOperatSost)
                .HasMaxLength(255)
                .HasColumnName("CD_OPERAT_SOST");
            entity.Property(e => e.CdOperazione)
                .HasMaxLength(255)
                .HasColumnName("CD_OPERAZIONE");
            entity.Property(e => e.CdProcesso)
                .HasMaxLength(255)
                .HasColumnName("CD_PROCESSO");
            entity.Property(e => e.CdStamContab)
                .HasMaxLength(255)
                .HasColumnName("CD_STAM_CONTAB");
            entity.Property(e => e.CdStsOpe)
                .HasMaxLength(255)
                .HasColumnName("CD_STS_OPE");
            entity.Property(e => e.CdTerm)
                .HasMaxLength(255)
                .HasColumnName("CD_TERM");
            entity.Property(e => e.CdTipCassa)
                .HasMaxLength(255)
                .HasColumnName("CD_TIP_CASSA");
            entity.Property(e => e.CdTipOpe)
                .HasMaxLength(255)
                .HasColumnName("CD_TIP_OPE");
            entity.Property(e => e.CodFormTec1)
                .HasMaxLength(255)
                .HasColumnName("COD_FORM_TEC1");
            entity.Property(e => e.CodFormTec2)
                .HasMaxLength(255)
                .HasColumnName("COD_FORM_TEC2");
            entity.Property(e => e.CodVers)
                .HasMaxLength(255)
                .HasColumnName("COD_VERS");
            entity.Property(e => e.DettXml).HasColumnName("DETT_XML");
            entity.Property(e => e.DlOgg)
                .HasMaxLength(255)
                .HasColumnName("DL_OGG");
            entity.Property(e => e.DtCont)
                .HasMaxLength(255)
                .HasColumnName("DT_CONT");
            entity.Property(e => e.FlAntiric)
                .HasMaxLength(255)
                .HasColumnName("FL_ANTIRIC");
            entity.Property(e => e.FlCircolarita)
                .HasMaxLength(255)
                .HasColumnName("FL_CIRCOLARITA");
            entity.Property(e => e.FlFrz)
                .HasMaxLength(255)
                .HasColumnName("FL_FRZ");
            entity.Property(e => e.FlOffHost)
                .HasMaxLength(255)
                .HasColumnName("FL_OFF_HOST");
            entity.Property(e => e.FlOffLine)
                .HasMaxLength(255)
                .HasColumnName("FL_OFF_LINE");
            entity.Property(e => e.FlOpeResto)
                .HasMaxLength(255)
                .HasColumnName("FL_OPE_RESTO");
            entity.Property(e => e.FlPresAss)
                .HasMaxLength(255)
                .HasColumnName("FL_PRES_ASS");
            entity.Property(e => e.IdCassaHost)
                .HasMaxLength(255)
                .HasColumnName("ID_CASSA_HOST");
            entity.Property(e => e.IdCassetta)
                .HasMaxLength(255)
                .HasColumnName("ID_CASSETTA");
            entity.Property(e => e.IdCliCrm)
                .HasMaxLength(255)
                .HasColumnName("ID_CLI_CRM");
            entity.Property(e => e.IdOpeCom)
                .HasMaxLength(255)
                .HasColumnName("ID_OPE_COM");
            entity.Property(e => e.IdOperHost)
                .HasMaxLength(255)
                .HasColumnName("ID_OPER_HOST");
            entity.Property(e => e.IdOperaz)
                .HasMaxLength(255)
                .HasColumnName("ID_OPERAZ");
            entity.Property(e => e.IdenTran)
                .HasMaxLength(255)
                .HasColumnName("IDEN_TRAN");
            entity.Property(e => e.ImTotale)
                .HasMaxLength(255)
                .HasColumnName("IM_TOTALE");
            entity.Property(e => e.NmPrgHstMax)
                .HasMaxLength(255)
                .HasColumnName("NM_PRG_HST_MAX");
            entity.Property(e => e.NmPrgHstMin)
                .HasMaxLength(255)
                .HasColumnName("NM_PRG_HST_MIN");
            entity.Property(e => e.NmPrgHstMinAnn)
                .HasMaxLength(255)
                .HasColumnName("NM_PRG_HST_MIN_ANN");
            entity.Property(e => e.NmPrgIstituto)
                .HasMaxLength(255)
                .HasColumnName("NM_PRG_ISTITUTO");
            entity.Property(e => e.NmPrgOpe)
                .HasMaxLength(255)
                .HasColumnName("NM_PRG_OPE");
            entity.Property(e => e.NmPrgOpePdl)
                .HasMaxLength(255)
                .HasColumnName("NM_PRG_OPE_PDL");
            entity.Property(e => e.NmPrgRel)
                .HasMaxLength(255)
                .HasColumnName("NM_PRG_REL");
            entity.Property(e => e.NmQcontabile)
                .HasMaxLength(255)
                .HasColumnName("NM_QCONTABILE");
            entity.Property(e => e.NmSeq)
                .HasMaxLength(255)
                .HasColumnName("NM_SEQ");
            entity.Property(e => e.SessHandle)
                .HasMaxLength(255)
                .HasColumnName("SESS_HANDLE");
            entity.Property(e => e.TipModPag)
                .HasMaxLength(255)
                .HasColumnName("TIP_MOD_PAG");
            entity.Property(e => e.TsStor)
                .HasMaxLength(255)
                .HasColumnName("TS_STOR");
            entity.Property(e => e.TsVarSts)
                .HasMaxLength(255)
                .HasColumnName("TS_VAR_STS");
            entity.Property(e => e.ValoFormTec1)
                .HasMaxLength(255)
                .HasColumnName("VALO_FORM_TEC1");
            entity.Property(e => e.ValoFormTec2)
                .HasMaxLength(255)
                .HasColumnName("VALO_FORM_TEC2");
        });

        modelBuilder.Entity<Glossario>(entity =>
        {
            entity.HasKey(e => e.Cod).HasName("GLOS_PK");

            entity.ToTable("GLOSSARIO", "SDP2");

            entity.Property(e => e.Cod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD");
            entity.Property(e => e.DescBrev)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DESC_BREV");
            entity.Property(e => e.DescEste)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DESC_ESTE");
            entity.Property(e => e.DtFineVali)
                .HasDefaultValue(new DateOnly(2999, 12, 31))
                .HasColumnName("DT_FINE_VALI");
            entity.Property(e => e.DtInizVali)
                .HasDefaultValue(new DateOnly(1900, 1, 1))
                .HasColumnName("DT_INIZ_VALI");
            entity.Property(e => e.VersSoftFine)
                .HasDefaultValue((short)9999)
                .HasColumnName("VERS_SOFT_FINE");
            entity.Property(e => e.VersSoftIniz).HasColumnName("VERS_SOFT_INIZ");
        });

        modelBuilder.Entity<Inc200>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Inc200");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NomeCampo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Messaggi>(entity =>
        {
            entity.HasKey(e => e.IdMessaggio).HasName("PK__Messaggi__95A4565EC2FCA5E1");

            entity.ToTable("Messaggi");

            entity.Property(e => e.IdMessaggio).HasMaxLength(20);
            entity.Property(e => e.Stato)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TestoMessaggio).IsUnicode(false);
            entity.Property(e => e.Titolo).IsUnicode(false);
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => e.MigrationId);

            entity.ToTable("_MigrationHistory", "DemRic");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<MoniSintOffl>(entity =>
        {
            entity.HasKey(e => e.TsUpdtMoni).HasName("MONI_SINT_OFFL_PK");

            entity.ToTable("MONI_SINT_OFFL", "SDP2");

            entity.Property(e => e.TsUpdtMoni)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("TS_UPDT_MONI");
        });

        modelBuilder.Entity<MonitoringBuste>(entity =>
        {
            entity.HasKey(e => e.IdMonitoringBuste).HasName("PK__Monitori__07D2E1FDAAC67969");

            entity.ToTable("MonitoringBuste");

            entity.Property(e => e.IdMonitoringBuste).HasColumnName("idMonitoringBuste");
            entity.Property(e => e.CodiceOperatoreBusta)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CodiceOperatoreControllo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.DataContabile).HasColumnType("datetime");
            entity.Property(e => e.DataEsecuzioneControllo).HasColumnType("datetime");
            entity.Property(e => e.DataInsertMonitoring)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Frazionario)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.IdBustaOperatore)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IdControlloBusta)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StatoA)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StatoDa)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MonitoringScatole>(entity =>
        {
            entity.HasKey(e => e.IdMonitoringScatole).HasName("PK__Monitori__ADBB21C120DC9FF3");

            entity.ToTable("MonitoringScatole");

            entity.Property(e => e.IdMonitoringScatole).HasColumnName("idMonitoringScatole");
            entity.Property(e => e.CodiceOperatore)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CodiceRaccomandata)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.DataFineAfferenza).HasColumnType("datetime");
            entity.Property(e => e.DataInizioAfferenza).HasColumnType("datetime");
            entity.Property(e => e.DataInsertMonitoring)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Frazionario)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.IdScatola)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IdScatolaArchiviata)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.MotivazioneSmarrimento)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StatoA)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StatoDa)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Operazioni>(entity =>
        {
            entity.HasKey(e => e.IdRicevuta).HasName("PK__Operazio__94DB76948C97B230");

            entity.ToTable("Operazioni", "DemRic", tb => tb.HasTrigger("trg_DeleteOperazioniStoricizzazione"));

            entity.Property(e => e.IdRicevuta)
                .ValueGeneratedNever()
                .HasColumnName("Id_Ricevuta");
            entity.Property(e => e.Attributes).IsUnicode(false);
            entity.Property(e => e.CodiceContabile).IsUnicode(false);
            entity.Property(e => e.CodiceFase)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Codice_Fase");
            entity.Property(e => e.DataAggStatoFirma)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("data_agg_stato_firma");
            entity.Property(e => e.DataContabile).HasColumnName("Data_Contabile");
            entity.Property(e => e.DataOperazione)
                .HasColumnType("datetime")
                .HasColumnName("Data_Operazione");
            entity.Property(e => e.DeliveredAcarrello)
                .HasDefaultValue(false)
                .HasColumnName("DeliveredACarrello");
            entity.Property(e => e.DeliveryDifferita).HasDefaultValue(false);
            entity.Property(e => e.DeliveryDigitale).HasDefaultValue(false);
            entity.Property(e => e.DescrizioneFase).IsUnicode(false);
            entity.Property(e => e.Frazionario)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.IdCarrello).IsUnicode(false);
            entity.Property(e => e.IdentificativoFiscale)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Identificativo_Fiscale");
            entity.Property(e => e.Importo).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.NomeFileFirmato)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome_file_firmato");
            entity.Property(e => e.NumeroOperazione)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Numero_Operazione");
            entity.Property(e => e.Pdl)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.SottocategoriaFase)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Sottocategoria_Fase");
            entity.Property(e => e.StampaDifferita).HasColumnName("Stampa_Differita");
            entity.Property(e => e.StatoFirma)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stato_firma");
            entity.Property(e => e.SysDataInserimento)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Sys_Data_Inserimento");
        });

        modelBuilder.Entity<OperazioniOtp>(entity =>
        {
            entity.HasKey(e => e.SystemId).HasName("PK__Operazio__C71788F2517C6CF9");

            entity.ToTable("OperazioniOTP", "DemRic");

            entity.Property(e => e.SystemId).HasColumnName("System_Id");
            entity.Property(e => e.DataCreazione)
                .HasColumnType("datetime")
                .HasColumnName("Data_Creazione");
            entity.Property(e => e.IdRicevuta).HasColumnName("Id_Ricevuta");
            entity.Property(e => e.Password).HasMaxLength(150);
            entity.Property(e => e.Salt).HasMaxLength(12);
            entity.Property(e => e.SysDataInserimento)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Sys_Data_Inserimento");

            entity.HasOne(d => d.IdRicevutaNavigation).WithMany(p => p.OperazioniOtps)
                .HasForeignKey(d => d.IdRicevuta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Operazioni_OperazioniOtp");
        });

        modelBuilder.Entity<OperazioniRicevute>(entity =>
        {
            entity.HasKey(e => e.SystemId).HasName("PK__Operazio__C71788F21DB32A79");

            entity.ToTable("OperazioniRicevute", "DemRic");

            entity.Property(e => e.SystemId).HasColumnName("System_Id");
            entity.Property(e => e.IdRicevuta).HasColumnName("Id_Ricevuta");
            entity.Property(e => e.SysDataInserimento)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Sys_Data_Inserimento");

            entity.HasOne(d => d.IdRicevutaNavigation).WithMany(p => p.OperazioniRicevutes)
                .HasForeignKey(d => d.IdRicevuta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Operazioni_OperazioniRicevute");
        });

        modelBuilder.Entity<OperazioniStorico>(entity =>
        {
            entity.HasKey(e => e.IdRicevuta).HasName("PK__Operazio__94DB769404C8D666");

            entity.ToTable("Operazioni_Storico", "DemRic");

            entity.Property(e => e.IdRicevuta)
                .ValueGeneratedNever()
                .HasColumnName("Id_Ricevuta");
            entity.Property(e => e.Attributes).IsUnicode(false);
            entity.Property(e => e.CodiceContabile).IsUnicode(false);
            entity.Property(e => e.CodiceFase)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Codice_Fase");
            entity.Property(e => e.DataAggStatoFirma)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("data_agg_stato_firma");
            entity.Property(e => e.DataContabile).HasColumnName("Data_Contabile");
            entity.Property(e => e.DataOperazione)
                .HasColumnType("datetime")
                .HasColumnName("Data_Operazione");
            entity.Property(e => e.DataOraSvecchiamento).HasColumnType("datetime");
            entity.Property(e => e.DeliveredAcarrello)
                .HasDefaultValue(false)
                .HasColumnName("DeliveredACarrello");
            entity.Property(e => e.DeliveryDifferita).HasDefaultValue(false);
            entity.Property(e => e.DeliveryDigitale).HasDefaultValue(false);
            entity.Property(e => e.DescrizioneFase).IsUnicode(false);
            entity.Property(e => e.Frazionario)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.IdCarrello).IsUnicode(false);
            entity.Property(e => e.IdentificativoFiscale)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Identificativo_Fiscale");
            entity.Property(e => e.Importo).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.NomeFileFirmato)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome_file_firmato");
            entity.Property(e => e.NumeroOperazione)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Numero_Operazione");
            entity.Property(e => e.Pdl)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.SottocategoriaFase)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Sottocategoria_Fase");
            entity.Property(e => e.StampaDifferita).HasColumnName("Stampa_Differita");
            entity.Property(e => e.StatoFirma)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stato_firma");
            entity.Property(e => e.SysDataInserimento)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Sys_Data_Inserimento");
        });

        modelBuilder.Entity<ResponseRicercheStoriche>(entity =>
        {
            entity.HasKey(e => e.IdResponse);

            entity.ToTable("ResponseRicercheStoriche");

            entity.Property(e => e.BusteBb).HasColumnName("BusteBB");
            entity.Property(e => e.BusteBe).HasColumnName("BusteBE");
            entity.Property(e => e.BusteBo).HasColumnName("BusteBO");
            entity.Property(e => e.DocumentiBb).HasColumnName("DocumentiBB");
            entity.Property(e => e.EventiBb).HasColumnName("EventiBB");
            entity.Property(e => e.EventiBe).HasColumnName("EventiBE");
            entity.Property(e => e.EventiBo).HasColumnName("EventiBO");
            entity.Property(e => e.EventiSc).HasColumnName("EventiSC");
            entity.Property(e => e.RicevuteBe).HasColumnName("RicevuteBE");
            entity.Property(e => e.RicevuteBo).HasColumnName("RicevuteBO");

            entity.HasOne(d => d.IdRicercaNavigation).WithMany(p => p.ResponseRicercheStoriches).HasForeignKey(d => d.IdRicerca);
        });

        modelBuilder.Entity<RicercheStoriche>(entity =>
        {
            entity.HasKey(e => e.IdRicerca).HasName("PK__Ricerche__1750622247CCBC7D");

            entity.ToTable("RicercheStoriche");

            entity.Property(e => e.DataFineRicerca).HasColumnType("datetime");
            entity.Property(e => e.DataInizioRicerca)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FiltroCategoria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Filtro_Categoria");
            entity.Property(e => e.FiltroCodiceFase)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Filtro_CodiceFase");
            entity.Property(e => e.FiltroCodiceRaccomandata)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Filtro_CodiceRaccomandata");
            entity.Property(e => e.FiltroData).HasColumnName("Filtro_Data");
            entity.Property(e => e.FiltroDataA).HasColumnName("Filtro_DataA");
            entity.Property(e => e.FiltroDataAscatolaInviata).HasColumnName("Filtro_DataAScatolaInviata");
            entity.Property(e => e.FiltroDataDa).HasColumnName("Filtro_DataDa");
            entity.Property(e => e.FiltroDataDaScatolaInviata).HasColumnName("Filtro_DataDaScatolaInviata");
            entity.Property(e => e.FiltroDataScatolaInviata).HasColumnName("Filtro_DataScatolaInviata");
            entity.Property(e => e.FiltroFrazionario)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Filtro_Frazionario");
            entity.Property(e => e.FiltroIdBusta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Filtro_IdBusta");
            entity.Property(e => e.FiltroIdScatola)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Filtro_IdScatola");
            entity.Property(e => e.FiltroSottocategoria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Filtro_Sottocategoria");
            entity.Property(e => e.FiltroStatoBusta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Filtro_StatoBusta");
            entity.Property(e => e.FiltroStatoScatola)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Filtro_StatoScatola");
            entity.Property(e => e.FiltroTipoElemento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Filtro_TipoElemento");
            entity.Property(e => e.FiltroTipoRicerca).HasColumnName("Filtro_TipoRicerca");
            entity.Property(e => e.FiltroUtenza)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Filtro_Utenza");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RicevuteBustaOperatore>(entity =>
        {
            entity.HasKey(e => new { e.CodiceOperazione, e.DataCreazione });

            entity.ToTable("RicevuteBustaOperatore");

            entity.HasIndex(e => new { e.DataCreazione, e.IdBusta }, "IX_RicevuteBustaOperatore_IdBusta");

            entity.HasIndex(e => new { e.DataCreazione, e.Stato }, "IX_RicevuteBustaOperatore_Stato");

            entity.Property(e => e.DataCreazione)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CodiceFase)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodiceOperatore)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CodiceOperatoreModifica)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CodicePdl)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CodicePDL");
            entity.Property(e => e.DataCreazioneCdcgdf)
                .HasColumnType("datetime")
                .HasColumnName("DataCreazioneCDCGdf");
            entity.Property(e => e.DataModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataOperazione).HasColumnType("datetime");
            entity.Property(e => e.Frazionario)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.IdBusta)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Importo).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MotivazioneAssenza).IsUnicode(false);
            entity.Property(e => e.NumeroCassa)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Stato)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Unknown");
            entity.Property(e => e.TipoOperazione)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Titolo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RicevuteBustaOperatoreHistory>(entity =>
        {
            entity.HasKey(e => new { e.CodiceOperazione, e.DataCreazione });

            entity.ToTable("RicevuteBustaOperatore_History");

            entity.Property(e => e.DataCreazione)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CodiceFase)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodiceOperatore)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CodiceOperatoreModifica)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CodicePdl)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CodicePDL");
            entity.Property(e => e.DataModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataOperazione).HasColumnType("datetime");
            entity.Property(e => e.Frazionario)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.IdBusta)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Importo).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MotivazioneAssenza).IsUnicode(false);
            entity.Property(e => e.NumeroCassa)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Stato)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Unknown");
            entity.Property(e => e.TipoOperazione)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Titolo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Ritm0757720Inc03620891>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RITM0757720-INC03620891");

            entity.Property(e => e.CodiceRaccomandata)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdScatola)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Stato)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Rollout>(entity =>
        {
            entity.HasKey(e => e.Frazionario);

            entity.ToTable("Rollout");

            entity.Property(e => e.Frazionario)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Scatole>(entity =>
        {
            entity.HasKey(e => e.IdScatola);

            entity.ToTable("Scatole");

            entity.HasIndex(e => new { e.Frazionario, e.Stato }, "IX_Scatole_Frazionario_Stato");

            entity.Property(e => e.IdScatola)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodiceOperatore)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CodiceOperatoreChiusura)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CodiceOperatoreModifica)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CodiceRaccomandata)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.DataAfferenzaA).HasColumnType("datetime");
            entity.Property(e => e.DataAfferenzaDa).HasColumnType("datetime");
            entity.Property(e => e.DataApertura)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataArchiviazione).HasColumnType("datetime");
            entity.Property(e => e.DataChiusura).HasColumnType("datetime");
            entity.Property(e => e.DataCreazione)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataInvio).HasColumnType("datetime");
            entity.Property(e => e.DataModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Frazionario)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.IdScatolaMagazzino)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.NoteDiSmarrimento)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Stato)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Unkown");
        });

        modelBuilder.Entity<ScatoleAvezzano>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ScatoleAvezzano");

            entity.Property(e => e.Bonifica)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CodiceRaccomandata)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.DataChiusura)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Frazionario)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.IdScatola)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Stato)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SottocategorieFasi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SottocategorieFasi");

            entity.Property(e => e.CodiceFase)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodiceFormaTecnica1)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CodiceFormaTecnica2)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.ObbligoFormeTecniche)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SottocategoriaFase)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)");
        });

        modelBuilder.Entity<StatisticheKafka>(entity =>
        {
            entity.HasKey(e => new { e.StartDate, e.EndDate, e.TipoTable, e.TipoOperazione }).HasName("PK_STATISTICHE_KAFKA");

            entity.ToTable("StatisticheKafka");

            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.TipoTable)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TipoOperazione)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<StruttureLogistiche>(entity =>
        {
            entity.HasKey(e => new { e.Codice, e.Tipo, e.CodiceStrutturaParent }).HasName("PK__Struttur__31031B368169BD73");

            entity.ToTable("StruttureLogistiche");

            entity.Property(e => e.Codice)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CodiceStrutturaParent)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DataAbilitazione).HasColumnType("datetime");
            entity.Property(e => e.DataCreazione)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SvecchiamentoLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Svecchia__3214EC07FA49C280");

            entity.ToTable("SvecchiamentoLogs", "DemRic");

            entity.Property(e => e.ExecutionDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Execution_DateTime");
            entity.Property(e => e.Status).HasMaxLength(10);
        });

        modelBuilder.Entity<SysRicercheOperazioni>(entity =>
        {
            entity.ToTable("Sys_RicercheOperazioni");

            entity.Property(e => e.Esito)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Request).IsUnicode(false);
            entity.Property(e => e.Response).IsUnicode(false);
            entity.Property(e => e.Start).HasColumnType("datetime");
            entity.Property(e => e.Stop).HasColumnType("datetime");
            entity.Property(e => e.TipoRicerca)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tbanaope>(entity =>
        {
            entity.HasKey(e => new { e.CdOpe, e.CdLing, e.DtInizVali, e.VersSoftIniz }).HasName("TBANAOPE_PK");

            entity.ToTable("TBANAOPE", "SDP2");

            entity.Property(e => e.CdOpe)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CD_OPE");
            entity.Property(e => e.CdLing)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CD_LING");
            entity.Property(e => e.DtInizVali)
                .HasDefaultValue(new DateOnly(1900, 1, 1))
                .HasColumnName("DT_INIZ_VALI");
            entity.Property(e => e.VersSoftIniz)
                .HasDefaultValue((short)1)
                .HasColumnName("VERS_SOFT_INIZ");
            entity.Property(e => e.DlOgg)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DL_OGG");
            entity.Property(e => e.DsBreve)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DS_BREVE");
            entity.Property(e => e.DtFineVali)
                .HasDefaultValue(new DateOnly(2999, 12, 31))
                .HasColumnName("DT_FINE_VALI");
            entity.Property(e => e.VersSoftFine)
                .HasDefaultValue((short)9999)
                .HasColumnName("VERS_SOFT_FINE");
        });

        modelBuilder.Entity<Tbcatope>(entity =>
        {
            entity.HasKey(e => new { e.CdBanca, e.CdCanale, e.CdOpe, e.DtInizVali, e.VersSoftIniz }).HasName("TBCATOPE_PK");

            entity.ToTable("TBCATOPE", "SDP2");

            entity.Property(e => e.CdBanca)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CD_BANCA");
            entity.Property(e => e.CdCanale)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CD_CANALE");
            entity.Property(e => e.CdOpe)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CD_OPE");
            entity.Property(e => e.DtInizVali)
                .HasDefaultValue(new DateOnly(1900, 1, 1))
                .HasColumnName("DT_INIZ_VALI");
            entity.Property(e => e.VersSoftIniz)
                .HasDefaultValue((short)1)
                .HasColumnName("VERS_SOFT_INIZ");
            entity.Property(e => e.CdChiusuraKo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CD_CHIUSURA_KO");
            entity.Property(e => e.CdChiusuraOk)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CD_CHIUSURA_OK");
            entity.Property(e => e.CdGrpAppartenenz)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CD_GRP_APPARTENENZ");
            entity.Property(e => e.CdGrpAr)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CD_GRP_AR");
            entity.Property(e => e.CdHelp)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CD_HELP");
            entity.Property(e => e.CdModSta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CD_MOD_STA");
            entity.Property(e => e.CdOpeAnn)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CD_OPE_ANN");
            entity.Property(e => e.CdOpeVis)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CD_OPE_VIS");
            entity.Property(e => e.CdOpeVisMenu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CD_OPE_VIS_MENU");
            entity.Property(e => e.CdPrcHst)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CD_PRC_HST");
            entity.Property(e => e.CdSegno)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("CD_SEGNO");
            entity.Property(e => e.CdSotsist)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CD_SOTSIST");
            entity.Property(e => e.CdStam)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("1")
                .IsFixedLength()
                .HasColumnName("CD_STAM");
            entity.Property(e => e.CdTipOpe)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CD_TIP_OPE");
            entity.Property(e => e.CdTipRegolam)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CD_TIP_REGOLAM");
            entity.Property(e => e.CdTipWin)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CD_TIP_WIN");
            entity.Property(e => e.CdTrxHst)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CD_TRX_HST");
            entity.Property(e => e.DlSrvReqAn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DL_SRV_REQ_AN");
            entity.Property(e => e.DtFineVali)
                .HasDefaultValue(new DateOnly(2999, 12, 31))
                .HasColumnName("DT_FINE_VALI");
            entity.Property(e => e.FlAbilitNcass)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_ABILIT_NCASS");
            entity.Property(e => e.FlAnn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_ANN");
            entity.Property(e => e.FlAnntecn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_ANNTECN");
            entity.Property(e => e.FlAntifro)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_ANTIFRO");
            entity.Property(e => e.FlAntiric)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_ANTIRIC");
            entity.Property(e => e.FlCauAntiric)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_CAU_ANTIRIC");
            entity.Property(e => e.FlCauUic)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_CAU_UIC");
            entity.Property(e => e.FlCircolarita)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_CIRCOLARITA");
            entity.Property(e => e.FlCommiss)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_COMMISS");
            entity.Property(e => e.FlDema)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("FL_DEMA");
            entity.Property(e => e.FlDisattivaz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_DISATTIVAZ");
            entity.Property(e => e.FlDivRap)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_DIV_RAP");
            entity.Property(e => e.FlExeOffHst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_EXE_OFF_HST");
            entity.Property(e => e.FlGdf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_GDF");
            entity.Property(e => e.FlLed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("FL_LED");
            entity.Property(e => e.FlMapOut)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_MAP_OUT");
            entity.Property(e => e.FlObbPresent)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_OBB_PRESENT");
            entity.Property(e => e.FlRelCli)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_REL_CLI");
            entity.Property(e => e.FlSospens)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_SOSPENS");
            entity.Property(e => e.FlStampa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_STAMPA");
            entity.Property(e => e.FlStatCont)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("FL_STAT_CONT");
            entity.Property(e => e.FlTrasFond)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("FL_TRAS_FOND");
            entity.Property(e => e.FlVeriContProl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("FL_VERI_CONT_PROL");
            entity.Property(e => e.FlagAmmiRist)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FLAG_AMMI_RIST");
            entity.Property(e => e.FlagCausUic)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FLAG_CAUS_UIC");
            entity.Property(e => e.FlagDivRapp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FLAG_DIV_RAPP");
            entity.Property(e => e.FlagLuw)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FLAG_LUW");
            entity.Property(e => e.FlagNumt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FLAG_NUMT");
            entity.Property(e => e.FlagOrac)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FLAG_ORAC");
            entity.Property(e => e.FlagOutp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FLAG_OUTP");
            entity.Property(e => e.FlagPrfz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FLAG_PRFZ");
            entity.Property(e => e.FlagRgsaXml)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FLAG_RGSA_XML");
            entity.Property(e => e.FlagRtry)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FLAG_RTRY");
            entity.Property(e => e.FlagRtryManu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FLAG_RTRY_MANU");
            entity.Property(e => e.FlagStamGior)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FLAG_STAM_GIOR");
            entity.Property(e => e.NmElmPag)
                .HasColumnType("decimal(3, 0)")
                .HasColumnName("NM_ELM_PAG");
            entity.Property(e => e.NmMaxMultiple)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("NM_MAX_MULTIPLE");
            entity.Property(e => e.NumRtryAmme)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("NUM_RTRY_AMME");
            entity.Property(e => e.PrgHost)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("PRG_HOST");
            entity.Property(e => e.StatCarr)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("A")
                .IsFixedLength()
                .HasColumnName("STAT_CARR");
            entity.Property(e => e.TipoBanc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("BPPI")
                .IsFixedLength()
                .HasColumnName("TIPO_BANC");
            entity.Property(e => e.VersSoftFine)
                .HasDefaultValue((short)9999)
                .HasColumnName("VERS_SOFT_FINE");
        });

        modelBuilder.Entity<TblProdottiFake>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TBL_PRODOTTI_Fake");

            entity.Property(e => e.Bancale)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANCALE");
            entity.Property(e => e.Cassetta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CASSETTA");
            entity.Property(e => e.DataEnd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DATA_END");
            entity.Property(e => e.DataIni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DATA_INI");
            entity.Property(e => e.Fraza)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FRAZA");
            entity.Property(e => e.Frazda)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FRAZDA");
            entity.Property(e => e.Tabella)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABELLA");
        });

        modelBuilder.Entity<Test>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Test");

            entity.Property(e => e.Altro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("altro");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Esito)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("esito");
            entity.Property(e => e.Note)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.Stato)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stato");
        });

        modelBuilder.Entity<TestTabellaEsiti>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Test_TABELLA_ESITI");

            entity.Property(e => e.CursorDataApertura)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TestTabellaStati>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Test_TABELLA_STATI");

            entity.Property(e => e.Stato)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stato");
        });

        modelBuilder.Entity<TipologicaCampiDocumento>(entity =>
        {
            entity.HasKey(e => e.NomeCampo).HasName("PK_ElencoClassificazioni");

            entity.ToTable("TipologicaCampiDocumento");

            entity.Property(e => e.NomeCampo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipologicaDocumenti>(entity =>
        {
            entity.HasKey(e => e.NomeDocumento).HasName("PK_Documenti_new");

            entity.ToTable("TipologicaDocumenti");

            entity.Property(e => e.NomeDocumento)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Descrizione).IsUnicode(false);
            entity.Property(e => e.FineValidita).HasColumnType("datetime");
            entity.Property(e => e.InizioValidita).HasColumnType("datetime");
            entity.Property(e => e.Tipo)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipologicaDocumentiCampiDocumento>(entity =>
        {
            entity.HasKey(e => new { e.NomeDocumento, e.NomeCampo }).HasName("PK_ElencoDocumentiClassificati");

            entity.ToTable("TipologicaDocumentiCampiDocumento");

            entity.Property(e => e.NomeDocumento)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NomeCampo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ordine).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<Tracce>(entity =>
        {
            entity.HasKey(e => new { e.CodiceOperazione, e.DataCreazione });

            entity.ToTable("TRACCE", "SDP2");

            entity.HasIndex(e => new { e.DataCreazione, e.IdOpeCom }, "IX_TRACCE_ID_OPE_COM, sysname,>");

            entity.HasIndex(e => new { e.DataCreazione, e.Frazionario, e.CodiceFase, e.IdOpeCom, e.DataOperazione, e.CdStsOpe }, "indx_Transazioni");

            entity.Property(e => e.DataCreazione)
                .HasDefaultValueSql("(((getutcdate() AT TIME ZONE 'UTC') AT TIME ZONE 'Central Europe Standard Time'))")
                .HasColumnType("datetime");
            entity.Property(e => e.CdStsOpe)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CD_STS_OPE");
            entity.Property(e => e.CodiceFase)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodiceFormaTecnica1)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodiceFormaTecnica2)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CodiceOperatore)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CodicePdl)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CodicePDL");
            entity.Property(e => e.DataCreazioneCdcdema)
                .HasColumnType("datetime")
                .HasColumnName("DataCreazioneCDCDema");
            entity.Property(e => e.DataCreazioneCdcgdf)
                .HasColumnType("datetime")
                .HasColumnName("DataCreazioneCDCGdf");
            entity.Property(e => e.DataLetturaKafkaDema).HasColumnType("datetime");
            entity.Property(e => e.DataLetturaKafkaGdF).HasColumnType("datetime");
            entity.Property(e => e.DataOperazione).HasColumnType("datetime");
            entity.Property(e => e.EsitoDematerializzazione)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Frazionario)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.IdOpeCom).HasColumnName("ID_OPE_COM");
            entity.Property(e => e.IdentificativoTransazione)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Importo).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Metadati).IsUnicode(false);
            entity.Property(e => e.ModalitaPagamento)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NumeroCassa)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.TipoOperazione)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.ValoreFormaTecnica1)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ValoreFormaTecnica2)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TracceHistory>(entity =>
        {
            entity.HasKey(e => new { e.CodiceOperazione, e.DataCreazione }).HasName("PK_TRACCE_History");

            entity.ToTable("TRACCE_HISTORY", "SDP2");

            entity.Property(e => e.DataCreazione)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CdStsOpe)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CD_STS_OPE");
            entity.Property(e => e.CodiceFase)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodiceFormaTecnica1)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodiceFormaTecnica2)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CodiceOperatore)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CodicePdl)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CodicePDL");
            entity.Property(e => e.DataOperazione).HasColumnType("datetime");
            entity.Property(e => e.EsitoDematerializzazione)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Frazionario)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.IdOpeCom).HasColumnName("ID_OPE_COM");
            entity.Property(e => e.IdentificativoTransazione)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Importo).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Metadati).IsUnicode(false);
            entity.Property(e => e.ModalitaPagamento)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NumeroCassa)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.TipoOperazione)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.ValoreFormaTecnica1)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ValoreFormaTecnica2)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Ufficio>(entity =>
        {
            entity.HasKey(e => e.Fraz).HasName("UFF_PK");

            entity.ToTable("UFFICIO", "SDP2");

            entity.Property(e => e.Fraz)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FRAZ");
            entity.Property(e => e.BckeCnfg).HasColumnName("BCKE_CNFG");
            entity.Property(e => e.Cap)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CAP");
            entity.Property(e => e.Civi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CIVI");
            entity.Property(e => e.CntrCost)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNTR_COST");
            entity.Property(e => e.CodComt).HasColumnName("COD_COMT");
            entity.Property(e => e.CodComu)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_COMU");
            entity.Property(e => e.CodDettTipoFraz)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_DETT_TIPO_FRAZ");
            entity.Property(e => e.CodProv)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_PROV");
            entity.Property(e => e.CodTipoUff).HasColumnName("COD_TIPO_UFF");
            entity.Property(e => e.DeflLimiGiacCass)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("DEFL_LIMI_GIAC_CASS");
            entity.Property(e => e.DeflLimiSicuCass)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("DEFL_LIMI_SICU_CASS");
            entity.Property(e => e.DescDettTipoFraz)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESC_DETT_TIPO_FRAZ");
            entity.Property(e => e.DescLoca)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESC_LOCA");
            entity.Property(e => e.DescUff)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESC_UFF");
            entity.Property(e => e.DtAttivUff).HasColumnName("DT_ATTIV_UFF");
            entity.Property(e => e.DtConfUff).HasColumnName("DT_CONF_UFF");
            entity.Property(e => e.DtDisaUff).HasColumnName("DT_DISA_UFF");
            entity.Property(e => e.DtUltiChiu).HasColumnName("DT_ULTI_CHIU");
            entity.Property(e => e.DtUltiConf)
                .HasPrecision(6)
                .HasColumnName("DT_ULTI_CONF");
            entity.Property(e => e.FlDema)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("FL_DEMA");
            entity.Property(e => e.FlTipoLavz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_TIPO_LAVZ");
            entity.Property(e => e.Indi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("INDI");
            entity.Property(e => e.LimiGiacUff)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("LIMI_GIAC_UFF");
            entity.Property(e => e.LimiSicuUff)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("LIMI_SICU_UFF");
            entity.Property(e => e.ModaLavoUff)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("S")
                .IsFixedLength()
                .HasColumnName("MODA_LAVO_UFF");
            entity.Property(e => e.NumMaxPdl).HasColumnName("NUM_MAX_PDL");
            entity.Property(e => e.NumPdlRetr).HasColumnName("NUM_PDL_RETR");
            entity.Property(e => e.VersSoft)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VERS_SOFT");
        });

        modelBuilder.Entity<ValoriBusteCampiDocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ValoriBu__3214EC078DFCEF9F");

            entity.ToTable("ValoriBusteCampiDocumento");

            entity.HasIndex(e => e.DocumentiBusteBackOfficeId, "IX_ValoriCampiDocumentoBusta_DocumentiBusteBackOfficeId");

            entity.Property(e => e.NomeCampo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Valore)
                .HasMaxLength(300)
                .IsUnicode(false);
        });
        modelBuilder.HasSequence("BustaOperatoreSequence")
            .HasMin(-223372036854775808L)
            .HasMax(223372036854775807L);
        modelBuilder.HasSequence("BusteBackOfficeSequence")
            .HasMin(-223372036854775808L)
            .HasMax(223372036854775807L);
        modelBuilder.HasSequence("BusteEccezioniSequence")
            .HasMin(-223372036854775808L)
            .HasMax(223372036854775807L);
        modelBuilder.HasSequence("ControlliBustaSequence")
            .HasMin(-223372036854775808L)
            .HasMax(223372036854775807L);
        modelBuilder.HasSequence("DocumentiBackofficeSequence")
            .HasMin(-223372036854775808L)
            .HasMax(223372036854775807L);
        modelBuilder.HasSequence("ScatolaSequence")
            .HasMin(-223372036854775808L)
            .HasMax(223372036854775807L);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
