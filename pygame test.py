import pygame
def main():
    pygame.init()
    logo = pygame.image.load("pygame_icon.bmp")
    pygame.display.set_icon(logo)
    pygame.display.set_caption("minimum program")
    screen = pygame.display.set_mode((240,180))
    screen.blit(logo, (50,50))
    pygame.display.flip()
    running = True
    while running:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                running = False
                exit()
if __name__=="__main__":
    main()
