namespace EasyLab.Models;

public partial class BasiAll
{
    // BasiModelli (PK composita IdContatto+IdStag+Mdl+Tess), BasiMateriali (PK composita IdContatto+Mat)
    // e TabTipoMateriale (PK CdTipoMat) non hanno una colonna Id univoca: IdMod/IdModNoStag/IdMat/IdTipoMat
    // restano risolti via dizionario (vedi Lookups/GetText in Articoli.razor) invece che con una relazione EF.
    public virtual SetTaglie? SetTaglie { get; set; }
    public virtual SetTaglieDett? SetTaglieDettBase { get; set; }
    public virtual SetTaglieDett? SetTaglieDettDa { get; set; }
    public virtual SetTaglieDett? SetTaglieDettA { get; set; }
    public virtual TabKw? TabKw { get; set; }
    public virtual Contatti? ContattiFornPref { get; set; }
    public virtual Contatti? ContattiLabPrev { get; set; }
    public virtual TabComposizione? TabComposizione1 { get; set; }
    public virtual TabComposizione? TabComposizione2 { get; set; }
    public virtual TabComposizione? TabComposizione3 { get; set; }
    public virtual TabComposizione? TabComposizione4 { get; set; }
    public virtual TabComposizione? TabComposizione5 { get; set; }
    public virtual TabComposizionePo? TabComposizionePo1 { get; set; }
    public virtual TabComposizionePo? TabComposizionePo2 { get; set; }
    public virtual TabComposizionePo? TabComposizionePo3 { get; set; }
    public virtual TabComposizionePo? TabComposizionePo4 { get; set; }
    public virtual TabComposizionePo? TabComposizionePo5 { get; set; }
    public virtual TabSimboliLav? TabSimboliLav1 { get; set; }
    public virtual TabSimboliLav? TabSimboliLav2 { get; set; }
    public virtual TabSimboliLav? TabSimboliLav3 { get; set; }
    public virtual TabSimboliLav? TabSimboliLav4 { get; set; }
    public virtual TabSimboliLav? TabSimboliLav5 { get; set; }
    public virtual TabSimboliLav? TabSimboliLav6 { get; set; }
    public virtual TabSimboliLav? TabSimboliLav11 { get; set; }
    public virtual TabSimboliLav? TabSimboliLav12 { get; set; }
    public virtual TabSimboliLav? TabSimboliLav13 { get; set; }
    public virtual TabSimboliLav? TabSimboliLav14 { get; set; }
    public virtual TabSimboliLav? TabSimboliLav15 { get; set; }
    public virtual TabSimboliLav? TabSimboliLav16 { get; set; }
    public virtual TabRagg? TabRagg1 { get; set; }
    public virtual TabRagg? TabRagg2 { get; set; }
    public virtual TabRagg? TabRagg3 { get; set; }
    public virtual TabRagg? TabRagg4 { get; set; }
    public virtual TabRagg? TabRagg5 { get; set; }
    public virtual TabCatMerceologica? TabCatMerceologica { get; set; }
    public virtual TabGender? TabGender { get; set; }
    public virtual TabTipoMpScar? TabTipoMpScar { get; set; }
    public virtual BasiImmagini? BasiImmagini { get; set; }
}
