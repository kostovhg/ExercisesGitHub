<?php

namespace SoftUniBlogBundle\Controller;

use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use SoftUniBlogBundle\Entity\Article;
use SoftUniBlogBundle\Form\ArticleType;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\HttpFoundation\Request;

class ArticleController extends Controller
{
    /**
     * @Route("/article/create", name="create_article")
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function createAction(Request $request)
    {
        $article = new Article();
        $form = $this->createForm(ArticleType::class, $article);

        $form->handleRequest($request);

        if ($form->isSubmitted() && $form->isValid()) {
            //$entityManager = $this->getDoctrine()->getManager();
            //$entityManager->persist($article);
            $user = $this->getUser();
            $article->setAuthor($user);
            $now = new \DateTime();
            $article->setCreatedOn($now);

            $em = $this->getDoctrine()->getManager();
            $em->persist($article);
            $em->flush();

            return $this->redirectToRoute('blog_index');
        }

        return $this->render(
            'article/create.html.twig',
            array('form' => $form->createView()));
    }

    /**
     * @Route("/article/{id}", name="article_show")
     * @param $id
     * @return \Symfony\Component\HttpFoundation\Response
     */

    public function showAction($id)
    {
        $articleRepository = $this->getDoctrine()->getRepository(
            Article::class
        );

        $article = $articleRepository->find($id);

        return $this->render("article/show.html.twig", [
            "article"=> $article
        ]);
    }

    public function indexAction($name)
    {
        return $this->render('', array('name' => $name));
    }
}
