# RimWorld - World Conquest

**World Conquest** é um mod de estratégia global para RimWorld inspirado em jogos de tabuleiro como War/Risk, onde cada colônia domina territórios no mapa mundial, expande fronteiras, gera renda e disputa o controle do planeta.

## Visão do mod

O objetivo é transformar o mapa mundial do RimWorld em um tabuleiro estratégico vivo.

Cada colônia/facção terá uma cor própria. Ao redor da cidade principal, tiles dominados serão marcados com essa cor. Quanto mais território uma cidade controla, maior será sua renda diária e sua influência global.

## Loop principal

```text
Criar colônia
↓
Expandir território
↓
Dominar tiles vizinhos
↓
Gerar prata e recursos
↓
Fortificar fronteiras
↓
Atacar ou defender regiões
↓
Crescer como império
```

## MVP inicial

A primeira versão deve focar em quatro sistemas simples:

1. Registrar dono de cada tile do mapa mundial.
2. Pintar os territórios dominados no mapa com a cor da facção/cidade.
3. Gerar renda diária em prata para cada território dominado.
4. Salvar e carregar os dados de domínio no save do RimWorld.

## Sistemas planejados

- Domínio territorial por tile.
- Fronteiras e expansão adjacente.
- Renda diária por território.
- Recursos especiais por bioma/tile.
- Fortificações de fronteira.
- Guerra entre colônias.
- Diplomacia e alianças.
- Ranking mundial.
- Eventos globais disputáveis.
- Compatibilidade futura com multiplayer.

## Estrutura do projeto

```text
RimWorld---World-Conquest/
├── About/
├── Defs/
├── Source/
├── Assemblies/
├── Textures/
├── Languages/
└── Docs/
```

## Status

Projeto em fase de fundação.

Primeiro objetivo técnico: criar o sistema de controle de tiles e renda básica.
