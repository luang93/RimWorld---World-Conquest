# Notas Técnicas

## Compilação

O projeto C# fica em:

```text
Source/WorldConquest/WorldConquest.csproj
```

A DLL compilada deve sair em:

```text
Assemblies/WorldConquest.dll
```

## Referências locais

Antes de compilar, ajuste os caminhos do `.csproj` para a pasta real do RimWorld no seu computador.

Caminho comum Steam/Windows:

```text
C:/Program Files (x86)/Steam/steamapps/common/RimWorld/RimWorldWin64_Data/Managed/
```

Arquivos usados:

```text
Assembly-CSharp.dll
UnityEngine.CoreModule.dll
UnityEngine.IMGUIModule.dll
```

## Arquitetura inicial

### TerritoryData

Representa um tile dominado.

Campos atuais:

- `tileId`
- `ownerFactionDefName`
- `ownerName`
- `influence`
- `defense`
- `dailySilverIncome`

### WorldConquestGameComponent

Responsável por:

- Guardar lista de territórios.
- Salvar/carregar dados no save.
- Verificar se tile já tem dono.
- Conquistar tile.
- Gerar renda diária.

## Próximo passo técnico

Criar um botão de debug no mapa mundial para testar conquista de tile.

Fluxo desejado:

```text
Clicar em tile no mapa mundial
↓
Botão: Conquistar território
↓
Sistema valida se é neutro
↓
Sistema valida se é adjacente
↓
Tile entra na lista de territórios
```

## Atenção

A renderização colorida no mapa mundial ainda não foi implementada. Ela será a parte mais importante da Fase 2.
