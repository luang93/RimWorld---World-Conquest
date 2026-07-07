# Arquitetura - World Conquest

Este documento define a arquitetura inicial do mod **World Conquest**.

## Objetivo técnico

Criar uma camada persistente de domínio territorial no mapa mundial do RimWorld.

O sistema precisa:

- Saber quais tiles pertencem a quem.
- Salvar/carregar domínio no save.
- Gerar renda diária.
- Permitir expansão por fronteira.
- Futuramente renderizar cores no mapa mundial.

---

## Camadas principais

```text
WorldConquestMod
↓
WorldConquestGameComponent
↓
TerritoryData
↓
Sistemas futuros:
TerritoryManager / EconomyManager / OverlayRenderer / WarManager
```

---

## 1. WorldConquestMod

Arquivo:

```text
Source/WorldConquest/WorldConquestMod.cs
```

Responsável pela inicialização do mod.

Uso atual:

- Registrar log de carregamento.
- Futuramente carregar configurações.
- Futuramente abrir menu de settings.

---

## 2. WorldConquestGameComponent

Arquivo:

```text
Source/WorldConquest/WorldConquestGameComponent.cs
```

Responsável pelo estado global salvo no save.

Responsabilidades atuais:

- Guardar lista de territórios.
- Salvar dados com `Scribe`.
- Carregar dados ao abrir save.
- Verificar se tile já tem dono.
- Conquistar tile.
- Gerar renda diária.

Responsabilidades futuras:

- Processar expansão automática de NPCs.
- Processar eventos globais.
- Processar guerras ativas.
- Atualizar influência territorial.

---

## 3. TerritoryData

Arquivo:

```text
Source/WorldConquest/TerritoryData.cs
```

Representa um tile dominado.

Campos atuais:

```text
tileId
ownerFactionDefName
ownerName
influence
defense
dailySilverIncome
```

Campos futuros possíveis:

```text
resourceType
biomeValue
fortificationLevel
lastAttackedDay
isCapitalArea
isStrategicPoint
```

---

## 4. Sistema de economia

Versão MVP:

```text
renda total = quantidade de tiles dominados × renda base
```

Renda base inicial:

```text
10 prata por tile por dia
```

Futuro:

```text
renda = valor base do tile + bônus de bioma + bônus de construção + bônus de influência
```

---

## 5. Sistema de expansão

Regra central:

```text
Só é possível conquistar tiles adjacentes ao território atual.
```

MVP:

- Conquista por botão/debug.
- Sem custo.
- Sem combate.

Futuro:

- Exigir caravana.
- Exigir item administrativo.
- Exigir tempo de ocupação.
- Exigir combate contra defesa local.

---

## 6. Overlay visual

Ainda não implementado.

Objetivo:

- Pintar tiles dominados no mapa mundial.
- Usar cor da facção/cidade.
- Mostrar tooltip com dados do território.
- Destacar fronteiras.

Caminho técnico provável:

- Criar classe de renderização no World Map.
- Usar Harmony patch se necessário.
- Renderizar malha/color overlay sobre tiles dominados.

---

## 7. Organização futura sugerida

```text
Source/WorldConquest/
├── Core/
│   ├── WorldConquestGameComponent.cs
│   ├── WorldConquestMod.cs
│   └── WorldConquestSettings.cs
├── Territory/
│   ├── TerritoryData.cs
│   ├── TerritoryManager.cs
│   └── TerritoryUtility.cs
├── Economy/
│   └── EconomyManager.cs
├── WorldMap/
│   ├── TerritoryOverlayRenderer.cs
│   └── WorldMapPatches.cs
├── UI/
│   └── Dialog_WorldConquestStatus.cs
└── War/
    └── WarManager.cs
```

---

## Prioridade técnica

1. Compilar DLL.
2. Confirmar que o mod carrega.
3. Confirmar que o `GameComponent` salva/carrega.
4. Criar comando de teste para conquistar tile.
5. Criar validação de adjacência.
6. Criar overlay visual.
